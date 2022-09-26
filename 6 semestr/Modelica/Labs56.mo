package Labs56
  package Lab6
  model TwoPortBody2D
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      parameter Real Color[3] = {0, 0, 255};
      parameter Modelica.SIunits.Mass m = 1;
      parameter Modelica.SIunits.MomentOfInertia J = 1;
      parameter Modelica.SIunits.Acceleration g = 9.81;
      Modelica.SIunits.Length X;
      Modelica.SIunits.Length Y;
      Modelica.SIunits.Angle Phi;
      Modelica.SIunits.Velocity Vx;
      Modelica.SIunits.Velocity Vy;
      Modelica.SIunits.AngularVelocity Omega;
      Modelica.SIunits.Acceleration Wx;
      Modelica.SIunits.Acceleration Wy;
      Modelica.SIunits.AngularAcceleration Epsilon;
      Modelica.SIunits.Force Fax;
      Modelica.SIunits.Force Fay;
      Modelica.SIunits.MomentOfForce Ma;
      Modelica.SIunits.Force Fbx;
      Modelica.SIunits.Force Fby;
      Modelica.SIunits.MomentOfForce Mb;
      Modelica.SIunits.Length CAx;
      Modelica.SIunits.Length CAy;
      Modelica.SIunits.Length CBx;
      Modelica.SIunits.Length CBy;
      KinematicOutput Body_Out;
      ForceInput FI_A;
      ForceInput FI_B;
    equation
      der(X) = Vx;
      der(Y) = Vy;
      der(Phi) = Omega;
      der(Vx) = Wx;
      der(Vy) = Wy;
      der(Omega) = Epsilon;
      CAx = FI_A.X - X;
      CAy = FI_A.Y - Y;
      CBx = FI_B.X - X;
      CBy = FI_B.Y - Y;
      m * Wx = Fax + Fbx;
      m * Wy = Fay + Fby - m * g;
      J * Epsilon = CAx * Fay - CAy * Fax + Ma + CBx * Fby - CBy * Fbx + Mb;
      Body_Out.X = X;
      Body_Out.Y = Y;
      Body_Out.Phi = Phi;
      FI_A.Fx = Fax;
      FI_A.Fy = Fay;
      FI_A.M = Ma;
      FI_B.Fx = Fbx;
      FI_B.Fy = Fby;
      FI_B.M = Mb;
    end TwoPortBody2D;
  
    connector KinematicOutput
      output Modelica.SIunits.Length X;
      output Modelica.SIunits.Length Y;
      output Modelica.SIunits.Angle Phi;
    end KinematicOutput;
  
    connector KinematicInput
      input Modelica.SIunits.Length X;
      input Modelica.SIunits.Length Y;
      input Modelica.SIunits.Angle Phi;
    end KinematicInput;
  
    connector ForceOutput
      output Modelica.SIunits.Length X;
      output Modelica.SIunits.Length Y;
      output Modelica.SIunits.Force Fx;
      output Modelica.SIunits.Force Fy;
      output Modelica.SIunits.MomentOfForce M;
    end ForceOutput;
  
    connector ForceInput
      input Modelica.SIunits.Length X;
      input Modelica.SIunits.Length Y;
      input Modelica.SIunits.Force Fx;
      input Modelica.SIunits.Force Fy;
      input Modelica.SIunits.MomentOfForce M;
    end ForceInput;
  
    model FreeEnd
      ForceOutput FO;
    equation
      FO.Fx = 0;
      FO.Fy = 0;
      FO.M = 0;
      FO.X = 0;
      FO.Y = 0;
    end FreeEnd;
  
    model TwoPortRod2D
      extends Labs56.Lab6.TwoPortBody2D;
      parameter Modelica.SIunits.Length L = 1;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "box", length = L, width = 0.1, height = 0.1, lengthDirection = {cos(Phi), sin(Phi), 0}, widthDirection = {0, 0, 1}, color = Color, specularCoefficient = 0.5, r = {X - L / 2 * cos(Phi), Y - L / 2 * sin(Phi), 0}, R = orientation, r_shape = {0, 0, 0});
    equation
  
    end TwoPortRod2D;
  
    model Support2D
      parameter Modelica.SIunits.Length Xp = 0;
      parameter Modelica.SIunits.Length Yp = 0;
      parameter Modelica.SIunits.Length Xt = 0;
      parameter Modelica.SIunits.Length Yt = 0;
      parameter Real Color[3] = {0, 100, 0};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "cylinder", length = 0.3, width = 0.15, height = 0.15, lengthDirection = {0, 0, 1}, widthDirection = {0, 1, 0}, color = Color, specularCoefficient = 0.5, r = {Xp, Yp, 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.SIunits.Force Rx;
      Modelica.SIunits.Force Ry;
      KinematicInput Body_In;
      ForceOutput FO;
    equation
      Xp = Body_In.X + Xt * cos(Body_In.Phi) - Yt * sin(Body_In.Phi);
      Yp = Body_In.Y + Xt * sin(Body_In.Phi) + Yt * cos(Body_In.Phi);
      FO.X = Xp;
      FO.Y = Yp;
      FO.Fx = Rx;
      FO.Fy = Ry;
      FO.M = 0;
    end Support2D;
  
    model Joint2D
      Modelica.SIunits.Length XSh;
      Modelica.SIunits.Length YSh;
      parameter Modelica.SIunits.Length Xt1 = 0;
      parameter Modelica.SIunits.Length Yt1 = 0;
      parameter Modelica.SIunits.Length Xt2 = 0;
      parameter Modelica.SIunits.Length Yt2 = 0;
      parameter Real Color[3] = {0, 0, 100};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "cylinder", length = 0.3, width = 0.15, height = 0.15, lengthDirection = {0, 0, 1}, widthDirection = {0, 1, 0}, color = Color, specularCoefficient = 0.5, r = {XSh, YSh, 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.SIunits.Force Rx;
      Modelica.SIunits.Force Ry;
      KinematicInput Body1_In;
      KinematicInput Body2_In;
      ForceOutput FO1;
      ForceOutput FO2;
    equation
      XSh = Body1_In.X + Xt1 * cos(Body1_In.Phi) - Yt1 * sin(Body1_In.Phi);
      YSh = Body1_In.Y + Xt1 * sin(Body1_In.Phi) + Yt1 * cos(Body1_In.Phi);
      XSh = Body2_In.X + Xt2 * cos(Body2_In.Phi) - Yt2 * sin(Body2_In.Phi);
      YSh = Body2_In.Y + Xt2 * sin(Body2_In.Phi) + Yt2 * cos(Body2_In.Phi);
      FO1.X = XSh;
      FO1.Y = YSh;
      FO1.Fx = Rx;
      FO1.Fy = Ry;
      FO1.M = 0;
      FO2.X = XSh;
      FO2.Y = YSh;
      FO2.Fx = -Rx;
      FO2.Fy = -Ry;
      FO2.M = 0;
    end Joint2D;
  
    model Slider2D
      parameter Modelica.SIunits.Length Xp = 0;
      parameter Modelica.SIunits.Length Yp = 0;
      parameter Modelica.SIunits.Angle Phip = 0;
      Modelica.SIunits.Length S;
      parameter Modelica.SIunits.Length Xt = 0;
      parameter Modelica.SIunits.Length Yt = 0;
      parameter Real Color[3] = {100, 0, 0};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape SliderPin(shapeType = "cylinder", length = 0.3, width = 0.15, height = 0.15, lengthDirection = {0, 0, 1}, widthDirection = {0, 1, 0}, color = Color, specularCoefficient = 0.5, r = {Xp + S * cos(Phip), Yp + S * sin(Phip), 0}, R = orientation, r_shape = {0, 0, 0});
      parameter Modelica.SIunits.Length L_Box = 0.3;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape SliderBox(shapeType = "box", length = L_Box, width = 0.15, height = 0.15, lengthDirection = {cos(Phip), sin(Phip), 0}, widthDirection = {0, 0, 1}, color = Color, specularCoefficient = 0.5, r = {Xp + S * cos(Phip) - L_Box / 2 * cos(Phip), Yp + S * sin(Phip) - L_Box / 2 * sin(Phip), 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.SIunits.Force N;
      KinematicInput Body_In;
      ForceOutput FO;
    equation
      Xp + S * cos(Phip) = Body_In.X + Xt * cos(Body_In.Phi) - Yt * sin(Body_In.Phi);
      Yp + S * sin(Phip) = Body_In.Y + Xt * sin(Body_In.Phi) + Yt * cos(Body_In.Phi);
      FO.X = Xp + S * cos(Phip);
      FO.Y = Yp + S * sin(Phip);
      FO.Fx = -N * sin(Phip);
      FO.Fy = N * cos(Phip);
      FO.M = 0;
    end Slider2D;
  
    model TwoPortWheel2D
      extends Labs56.Lab6.TwoPortBody2D;
      parameter Modelica.SIunits.Length R = 1;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape WheelShape(shapeType = "cylinder", length = 0.1, width = 2 * R, height = 2 * R, lengthDirection = {0, 0, 1}, widthDirection = {cos(Phi), sin(Phi), 0}, color = Color, specularCoefficient = 0.5, r = {X, Y, 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape WheelShape2(shapeType = "box", length = 0.2, width = R, height = R, lengthDirection = {0, 0, 1}, widthDirection = {cos(Phi), sin(Phi), 0}, color = Color * 0.5, specularCoefficient = 0.5, r = {X, Y, 0}, R = orientation, r_shape = {0, 0, 0});
    equation
  
    end TwoPortWheel2D;
  
    model RollWheelOnLine
      parameter Modelica.SIunits.Length Xp = 0;
      parameter Modelica.SIunits.Length Yp = 0;
      parameter Modelica.SIunits.Angle Phip = 0;
      Modelica.SIunits.Length S;
      parameter Modelica.SIunits.Length R = 1;
      parameter Real Color[3] = {100, 0, 0};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      parameter Modelica.SIunits.Length L_Box = 5;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape GroundBox(shapeType = "box", length = L_Box, width = 0.15, height = 0.15, lengthDirection = {cos(Phip), sin(Phip), 0}, widthDirection = {0, 0, 1}, color = Color, specularCoefficient = 0.5, r = {Xp - L_Box / 2 * cos(Phip), Yp - L_Box / 2 * sin(Phip), 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.SIunits.Force N;
      Modelica.SIunits.Force Ftr;
      KinematicInput Body_In;
      ForceOutput FO;
    equation
      Xp + S * cos(Phip) = Body_In.X + R * sin(Phip);
      Yp + S * sin(Phip) = Body_In.Y - R * cos(Phip);
      der(S) = -der(Body_In.Phi) * R;
      FO.X = Xp + S * cos(Phip);
      FO.Y = Yp + S * sin(Phip);
      FO.Fx = (-N * sin(Phip)) - Ftr * cos(Phip);
      FO.Fy = N * cos(Phip) - Ftr * sin(Phip);
      FO.M = 0;
    end RollWheelOnLine;
  
    model ThreePortBody2D
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      parameter Real Color[3] = {0, 0, 255};
      parameter Modelica.SIunits.Mass m = 1;
      parameter Modelica.SIunits.MomentOfInertia J = 1;
      parameter Modelica.SIunits.Acceleration g = 9.81;
      Modelica.SIunits.Length X;
      Modelica.SIunits.Length Y;
      Modelica.SIunits.Angle Phi;
      Modelica.SIunits.Velocity Vx;
      Modelica.SIunits.Velocity Vy;
      Modelica.SIunits.AngularVelocity Omega;
      Modelica.SIunits.Acceleration Wx;
      Modelica.SIunits.Acceleration Wy;
      Modelica.SIunits.AngularAcceleration Epsilon;
      Modelica.SIunits.Force Fax;
      Modelica.SIunits.Force Fay;
      Modelica.SIunits.MomentOfForce Ma;
      Modelica.SIunits.Force Fbx;
      Modelica.SIunits.Force Fby;
      Modelica.SIunits.MomentOfForce Mb;
      Modelica.SIunits.Force Fcx;
      Modelica.SIunits.Force Fcy;
      Modelica.SIunits.MomentOfForce Mc;
      Modelica.SIunits.Length CAx;
      Modelica.SIunits.Length CAy;
      Modelica.SIunits.Length CBx;
      Modelica.SIunits.Length CBy;
      Modelica.SIunits.Length CCx;
      Modelica.SIunits.Length CCy;
      KinematicOutput Body_Out;
      ForceInput FI_A;
      ForceInput FI_B;
      ForceInput FI_C;
    equation
      der(X) = Vx;
      der(Y) = Vy;
      der(Phi) = Omega;
      der(Vx) = Wx;
      der(Vy) = Wy;
      der(Omega) = Epsilon;
      CAx = FI_A.X - X;
      CAy = FI_A.Y - Y;
      CBx = FI_B.X - X;
      CBy = FI_B.Y - Y;
      CCx = FI_B.X - X;
      CCy = FI_C.Y - Y;
      m * Wx = Fax + Fbx + Fcx;
      m * Wy = Fay + Fby + Fcy - m * g;
      J * Epsilon = CAx * Fay - CAy * Fax + Ma + CBx * Fby - CBy * Fbx + Mb + CCx * Fcy - CCy * Fcx + Mc;
      Body_Out.X = X;
      Body_Out.Y = Y;
      Body_Out.Phi = Phi;
      FI_A.Fx = Fax;
      FI_A.Fy = Fay;
      FI_A.M = Ma;
      FI_B.Fx = Fbx;
      FI_B.Fy = Fby;
      FI_B.M = Mb;
      FI_C.Fx = Fcx;
      FI_C.Fy = Fcy;
      FI_C.M = Mc;
    end ThreePortBody2D;
  
    model ThreePortRod2D
      extends Labs56.Lab6.ThreePortBody2D;
      parameter Modelica.SIunits.Length L = 1;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "box", length = L, width = 0.1, height = 0.1, lengthDirection = {cos(Phi), sin(Phi), 0}, widthDirection = {0, 0, 1}, color = Color, specularCoefficient = 0.5, r = {X - L / 2 * cos(Phi), Y - L / 2 * sin(Phi), 0}, R = orientation, r_shape = {0, 0, 0});
    equation
  
    end ThreePortRod2D;
  
    model Variant3
    
      parameter Modelica.SIunits.Length L1 = 2;
      parameter Modelica.SIunits.Length L2 = 6;
      parameter Modelica.SIunits.Length L3 = 6;
      parameter Modelica.SIunits.Length L4 = 6;
      parameter Modelica.SIunits.Length R = 2;
      parameter Modelica.SIunits.Angle Phi10 = 2.5;
      parameter Modelica.SIunits.Angle Phi20 = 1.8;
      parameter Modelica.SIunits.Angle Phi30 = 0.3;
      parameter Modelica.SIunits.Angle Phi40 = 4.8;
      parameter Modelica.SIunits.Angle PhiK = 0;
      parameter Modelica.SIunits.Angle PhiP = - 1.5708;
      parameter Modelica.SIunits.Length XO = -6;
      parameter Modelica.SIunits.Length YO = -4;  
      parameter Modelica.SIunits.Length XP = XO + L1 * cos(Phi10) + L2 * cos(Phi20) + L3 * cos(Phi30)* 7/10;
      parameter Modelica.SIunits.Length YP = YO + L1 * sin(Phi10) + L2 * sin(Phi20) + L3 * sin(Phi30)* 7/10;
      parameter Modelica.SIunits.Length XP1 = XO + L1 * cos(Phi10) + L2 * cos(Phi20) + L3 * cos(Phi30)+ L4 * cos(Phi40) - R * cos (PhiK);
      parameter Modelica.SIunits.Length YP1 = YO + L1 * sin(Phi10) + L2 * sin(Phi20) + L3 * sin(Phi30) + L4 * sin(Phi40) - R* sin (PhiK);
      
      Engine Opora1(Xp = XO, Yp = YO, Xt = -L1 / 2, Yt = 0, Mdv = - 20);
      
      TwoPortRod2D Palka1(Color = {255, 0, 0}, L = L1, Phi(start = Phi10), m = 1);
      Joint2D Ssharnir1(Xt1 = L1 / 2, Yt1 = 0, Xt2 = -L2 / 2, Yt2 = 0);
      TwoPortRod2D Palka2(Color = {0, 255, 0}, L = L2, Phi(start = Phi20), m = 2);
      Joint2D Ssharnir2(Xt1 = L2 / 2, Yt1 = 0, Xt2 = -L3 / 2, Yt2 = 0);
      ThreePortRod2D Palka3(Color = {0, 0, 255}, L = L3, Phi(start = Phi30), m = 2);
      Joint2D Ssharnir3(Xt1 = L3 / 2, Yt1 = 0, Xt2 = -L4 / 2, Yt2 = 0);
      TwoPortRod2D Palka4(Color = {255, 255, 0}, L = L4, Phi(start = Phi40), m = 2);
      Joint2D Ssharnir4(Xt1 = L4 / 2, Yt1 = 0, Xt2 = 0, Yt2 = 0);
      TwoPortWheel2D Koleso(Color = {0, 0, 255}, R = R, Phi(start = PhiK), m = 0);
      RollCircleOnRealLine Roll(Xp = XP1, Yp = YP1, Phip = PhiP, R = R, delta = 20);  
      Support2D Opora2(Xp = XP, Yp = YP, Xt = L3 * 0.2, Yt = 0);
      
    equation
      connect(Palka1.Body_Out, Opora1.Body_In);
      connect(Palka1.Body_Out, Ssharnir1.Body1_In);
      connect(Palka2.Body_Out, Ssharnir1.Body2_In);
      connect(Palka2.Body_Out, Ssharnir2.Body1_In);
      connect(Palka3.Body_Out, Ssharnir2.Body2_In);
      connect(Palka3.Body_Out, Opora2.Body_In);
      connect(Palka3.Body_Out, Ssharnir3.Body1_In);
      connect(Palka4.Body_Out, Ssharnir3.Body2_In);
      connect(Palka4.Body_Out, Ssharnir4.Body1_In);
      connect(Koleso.Body_Out, Ssharnir4.Body2_In);
      connect(Koleso.Body_Out, Roll.Body_In);
      
      connect(Palka1.FI_A, Opora1.FO);
      connect(Palka1.FI_B, Ssharnir1.FO1);
      connect(Palka2.FI_A, Ssharnir1.FO2);
      connect(Palka2.FI_B, Ssharnir2.FO1);
      connect(Palka3.FI_A, Ssharnir2.FO2);
      connect(Palka3.FI_B, Opora2.FO);
      connect(Palka3.FI_C, Ssharnir3.FO1);
      connect(Palka4.FI_A, Ssharnir3.FO2);
      connect(Palka4.FI_B, Ssharnir4.FO1);
      connect(Koleso.FI_A, Ssharnir4.FO2);
      connect(Koleso.FI_B, Roll.FO);
      
      annotation(
        experiment(StartTime = 0, StopTime = 50, Tolerance = 1e-06, Interval = 0.001));
    
    end Variant3;
  
    model RollCircleOnRealLine
      parameter Modelica.SIunits.Length Xp = 0;
      parameter Modelica.SIunits.Length Yp = 0;
      parameter Modelica.SIunits.Angle Phip = 0;
      Modelica.SIunits.Length S;
      parameter Modelica.SIunits.Length delta = 0;
      parameter Modelica.SIunits.Length R = 1;
      parameter Real Color[3] = {100, 0, 0};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      parameter Modelica.SIunits.Length L_Box = 5;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape GroundBox(shapeType = "box", length = L_Box, width = 0.15, height = 0.15, lengthDirection = {cos(Phip), sin(Phip), 0}, widthDirection = {0, 0, 1}, color = Color, specularCoefficient = 0.5, r = {Xp - L_Box / 2 * cos(Phip), Yp - L_Box / 2 * sin(Phip), 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.SIunits.Force N;
      Modelica.SIunits.Force Ftr;
      KinematicInput Body_In;
      ForceOutput FO;
    equation
      Xp + S * cos(Phip) = Body_In.X + R * sin(Phip);
      Yp + S * sin(Phip) = Body_In.Y - R * cos(Phip);
      der(S) = -der(Body_In.Phi) * R;
      FO.X = Xp + S * cos(Phip);
      FO.Y = Yp + S * sin(Phip);
      FO.Fx = (-N * sin(Phip)) - Ftr * cos(Phip);
      FO.Fy = N * cos(Phip) - Ftr * sin(Phip);  
      
      FO.M = - delta * der(Body_In.Phi);
      
    end RollCircleOnRealLine;
  
    model Engine
      parameter Modelica.SIunits.Length Xp = 0;
      parameter Modelica.SIunits.Length Yp = 0;
      parameter Modelica.SIunits.Length Xt = 0;
      parameter Modelica.SIunits.Length Yt = 0;
      parameter Modelica.SIunits.MomentOfForce Mdv = 0;
      parameter Real Color[3] = {0, 100, 0};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "cylinder", length = 0.3, width = 0.15, height = 0.15, lengthDirection = {0, 0, 1}, widthDirection = {0, 1, 0}, color = Color, specularCoefficient = 0.5, r = {Xp, Yp, 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.SIunits.Force Rx;
      Modelica.SIunits.Force Ry;
      KinematicInput Body_In;
      ForceOutput FO;
    equation
      Xp = Body_In.X + Xt * cos(Body_In.Phi) - Yt * sin(Body_In.Phi);
      Yp = Body_In.Y + Xt * sin(Body_In.Phi) + Yt * cos(Body_In.Phi);
      FO.X = Xp;
      FO.Y = Yp;
      FO.Fx = Rx;
      FO.Fy = Ry;
      
      
      FO.M = Mdv;
      
      
    end Engine;
  
    model SpiralSpring
      Modelica.SIunits.Length XSh;
      Modelica.SIunits.Length YSh;
      parameter Modelica.SIunits.Length Xt1 = 0;
      parameter Modelica.SIunits.Length Yt1 = 0;
      parameter Modelica.SIunits.Length Xt2 = 0;
      parameter Modelica.SIunits.Length Yt2 = 0;
      parameter Modelica.SIunits.Angle alpha = 0;
      parameter Modelica.SIunits.MomentOfForce C = 0;
      parameter Real Color[3] = {0, 0, 100};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "cylinder", length = 0.3, width = 0.15, height = 0.15, lengthDirection = {0, 0, 1}, widthDirection = {0, 1, 0}, color = Color, specularCoefficient = 0.5, r = {XSh, YSh, 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.SIunits.Force Rx;
      Modelica.SIunits.Force Ry;
      KinematicInput Body1_In;
      KinematicInput Body2_In;
      ForceOutput FO1;
      ForceOutput FO2;
    equation
      XSh = Body1_In.X + Xt1 * cos(Body1_In.Phi) - Yt1 * sin(Body1_In.Phi);
      YSh = Body1_In.Y + Xt1 * sin(Body1_In.Phi) + Yt1 * cos(Body1_In.Phi);
      XSh = Body2_In.X + Xt2 * cos(Body2_In.Phi) - Yt2 * sin(Body2_In.Phi);
      YSh = Body2_In.Y + Xt2 * sin(Body2_In.Phi) + Yt2 * cos(Body2_In.Phi);
      FO1.X = XSh;
      FO1.Y = YSh;
      FO1.Fx = Rx;
      FO1.Fy = Ry;
      FO1.M = - C * (Body1_In.Phi - Body2_In.Phi + alpha);
      FO2.X = XSh;
      FO2.Y = YSh;
      FO2.Fx = -Rx;
      FO2.Fy = -Ry;
      FO2.M = C * (Body1_In.Phi - Body2_In.Phi + alpha);
    end SpiralSpring;
  end Lab6;
  
  model Lab5
  extends Modelica.SIunits;
  
    model Body2D
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      parameter Real Color[3] = {0, 0, 255};
      Modelica.SIunits.Length X;
      Modelica.SIunits.Length Y;
      Modelica.SIunits.Angle Phi;
      KinematicOutput Body_Out;
    equation
      Body_Out.X = X;
      Body_Out.Y = Y;
      Body_Out.Phi = Phi;
    end Body2D;
  
    connector KinematicOutput
      output Modelica.SIunits.Length X;
      output Modelica.SIunits.Length Y;
      output Modelica.SIunits.Angle Phi;
    end KinematicOutput;
  
    connector KinematicInput
      input Modelica.SIunits.Length X;
      input Modelica.SIunits.Length Y;
      input Modelica.SIunits.Angle Phi;
    end KinematicInput;
  
    model Rod2D
      extends Labs56.Lab5.Body2D;
      parameter Modelica.SIunits.Length L = 1;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "box", length = L, width = 0.1, height = 0.1, lengthDirection = {cos(Phi), sin(Phi), 0}, widthDirection = {0, 0, 1}, color = Color, specularCoefficient = 0.5, r = {X - L / 2 * cos(Phi), Y - L / 2 * sin(Phi), 0}, R = orientation, r_shape = {0, 0, 0});
    equation
  
    end Rod2D;
  
    model SvobodnayaPalka
      Rod2D Palka(Color = {255, 0, 0}, L = 3);
    equation
      Palka.X = sin(time);
      Palka.Y = cos(time);
      Palka.Phi = sin(-time);
    end SvobodnayaPalka;
  
    model Support2D
      parameter Modelica.SIunits.Length Xp = 0;
      parameter Modelica.SIunits.Length Yp = 0;
      parameter Modelica.SIunits.Length Xt = 0;
      parameter Modelica.SIunits.Length Yt = 0;
      parameter Real Color[3] = {0, 100, 0};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "cylinder", length = 0.3, width = 0.15, height = 0.15, lengthDirection = {0, 0, 1}, widthDirection = {0, 1, 0}, color = Color, specularCoefficient = 0.5, r = {Xp, Yp, 0}, R = orientation, r_shape = {0, 0, 0});
      KinematicInput Body_In;
    equation
      Xp = Body_In.X + Xt * cos(Body_In.Phi) - Yt * sin(Body_In.Phi);
      Yp = Body_In.Y + Xt * sin(Body_In.Phi) + Yt * cos(Body_In.Phi);
    end Support2D;
  
    model PalkaSOporoi
      parameter Modelica.SIunits.Length L1 = 3;
      Rod2D Palka(Color = {255, 0, 0}, L = L1);
      Support2D Opora(Xp = 1, Yp = -1, Xt = -L1 / 2, Yt = 0);
    equation
      connect(Palka.Body_Out, Opora.Body_In);
      Palka.Phi = sin(-time);
      annotation(
        experiment(StartTime = 0, StopTime = 10, Tolerance = 1e-06, Interval = 0.0002));
    end PalkaSOporoi;
  
    model Joint2D
  
      Modelica.SIunits.Length XSh;
      Modelica.SIunits.Length YSh;
      
      parameter Modelica.SIunits.Length Xt1 = 0;
      parameter Modelica.SIunits.Length Yt1 = 0;
      
      parameter Modelica.SIunits.Length Xt2 = 0;
      parameter Modelica.SIunits.Length Yt2 = 0;
      
      parameter Real Color[3] = {0, 0, 100};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape RodShape(shapeType = "cylinder", length = 0.3, width = 0.15, height = 0.15, lengthDirection = {0, 0, 1}, widthDirection = {0, 1, 0}, color = Color, specularCoefficient = 0.5, r = {XSh, YSh, 0}, R = orientation, r_shape = {0, 0, 0});
      KinematicInput Body1_In;
      KinematicInput Body2_In;
      
    equation
    
      XSh = Body1_In.X + Xt1 * cos(Body1_In.Phi) - Yt1 * sin(Body1_In.Phi);
      YSh = Body1_In.Y + Xt1 * sin(Body1_In.Phi) + Yt1 * cos(Body1_In.Phi);
      
      XSh = Body2_In.X + Xt2 * cos(Body2_In.Phi) - Yt2 * sin(Body2_In.Phi);
      YSh = Body2_In.Y + Xt2 * sin(Body2_In.Phi) + Yt2 * cos(Body2_In.Phi);
      
    end Joint2D;
  
    model DvePalkiSOporoi
    
      parameter Modelica.SIunits.Length L1 = 3;
      parameter Modelica.SIunits.Length L2 = 5;
      Rod2D Palka1(Color = {255, 0, 0}, L = L1);
      Rod2D Palka2(Color = {0, 255, 0}, L = L2);
      Support2D Opora(Xp = 1, Yp = -1, Xt = -L1 / 2, Yt = 0);
      Joint2D Ssharnir(Xt1 = L1 / 2, Yt1 = 0, Xt2 = -L2 / 2, Yt2 = 0);
      
    equation
    
      connect(Palka1.Body_Out, Opora.Body_In);
      connect(Palka1.Body_Out, Ssharnir.Body1_In);
      connect(Palka2.Body_Out, Ssharnir.Body2_In);
      
      Palka1.Phi = sin(-time);
      Palka2.Phi = cos(-time*3.815);
      
      annotation(
        experiment(StartTime = 0, StopTime = 10, Tolerance = 1e-06, Interval = 0.0002));
    
    end DvePalkiSOporoi;
  
    model TriPalkiSOporami
  
      parameter Modelica.SIunits.Length L1 = 1;
      parameter Modelica.SIunits.Length L2 = 5;
      parameter Modelica.SIunits.Length L3 = 5;
      Rod2D Palka1(Color = {255, 0, 0}, L = L1, Phi(start = -1.57));
      Rod2D Palka2(Color = {0, 255, 0}, L = L2, Phi(start = 0));
      Rod2D Palka3(Color = {0, 0, 255}, L = L3, Phi(start = 1.57));
      Support2D Opora1(Xp = 0, Yp = 0, Xt = -L1 / 2, Yt = 0);
      Joint2D Ssharnir1(Xt1 = L1 / 2, Yt1 = 0, Xt2 = -L2 / 2, Yt2 = 0);
      Joint2D Ssharnir2(Xt1 = L2 / 2, Yt1 = 0, Xt2 = -L3 / 2, Yt2 = 0);
      Support2D Opora2(Xp = 5, Yp = 1.5, Xt = 0, Yt = 0);
      
    equation
    
      connect(Palka1.Body_Out, Opora1.Body_In);
      connect(Palka1.Body_Out, Ssharnir1.Body1_In);
      connect(Palka2.Body_Out, Ssharnir1.Body2_In);
      
      connect(Palka3.Body_Out, Opora2.Body_In);
      connect(Palka2.Body_Out, Ssharnir2.Body1_In);
      connect(Palka3.Body_Out, Ssharnir2.Body2_In);
      
      der(Palka1.Phi) = 1;
      
      annotation(
        experiment(StartTime = 0, StopTime = 10, Tolerance = 1e-06, Interval = 0.0002));
    
    end TriPalkiSOporami;
  
    model Slider2D
    
      parameter Modelica.SIunits.Length Xp = 0;
      parameter Modelica.SIunits.Length Yp = 0;
      parameter Modelica.SIunits.Angle Phip = 0;
      
      Modelica.SIunits.Length S;
      
      parameter Modelica.SIunits.Length Xt = 0;
      parameter Modelica.SIunits.Length Yt = 0;
      
      parameter Real Color[3] = {100, 0, 0};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape SliderPin(shapeType = "cylinder", length = 0.3, width = 0.15, height = 0.15, lengthDirection = {0, 0, 1}, widthDirection = {0, 1, 0}, color = Color, specularCoefficient = 0.5, r = {Xp + S*cos(Phip), Yp + S*sin(Phip), 0}, R = orientation, r_shape = {0, 0, 0});
      
      parameter Modelica.SIunits.Length L_Box = 0.3;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape SliderBox(shapeType = "box", length = L_Box, width = 0.15, height = 0.15, lengthDirection = {cos(Phip), sin(Phip), 0}, widthDirection = {0, 0, 1}, color = Color, specularCoefficient = 0.5, r = {Xp + S*cos(Phip) - L_Box / 2 * cos(Phip), Yp + S*sin(Phip) - L_Box / 2 * sin(Phip), 0}, R = orientation, r_shape = {0, 0, 0});
      
      KinematicInput Body_In;
      
    equation
    
      Xp + S*cos(Phip) = Body_In.X + Xt * cos(Body_In.Phi) - Yt * sin(Body_In.Phi);
      Yp + S*sin(Phip) = Body_In.Y + Xt * sin(Body_In.Phi) + Yt * cos(Body_In.Phi);
      
    end Slider2D;
  
    model DvePalkiSPolzunom
    
      parameter Modelica.SIunits.Length L1 = 1;
      parameter Modelica.SIunits.Length L2 = 5;
      parameter Modelica.SIunits.Angle Phi10 = -1.57;
      parameter Modelica.SIunits.Angle Phi20 = 0;
      Rod2D Palka1(Color = {255, 0, 0}, L = L1, Phi(start = Phi10));
      Rod2D Palka2(Color = {0, 255, 0}, L = L2, Phi(start = Phi20));
      Support2D Opora(Xp = 0, Yp = 0, Xt = -L1 / 2, Yt = 0);
      Joint2D Ssharnir(Xt1 = L1 / 2, Yt1 = 0, Xt2 = -L2 / 2, Yt2 = 0);
      Slider2D Polzun(Xp = 5, Yp = -1, Phip = 0, Xt = L2 / 2, Yt = 0);
      
    equation
    
      connect(Palka1.Body_Out, Opora.Body_In);
      connect(Palka1.Body_Out, Ssharnir.Body1_In);
      connect(Palka2.Body_Out, Ssharnir.Body2_In);
      connect(Palka2.Body_Out, Polzun.Body_In);
      
      Palka1.Phi = time;
      
      annotation(
        experiment(StartTime = 0, StopTime = 10, Tolerance = 1e-06, Interval = 0.0002));
    
    end DvePalkiSPolzunom;
  
    model Wheel2D
      extends Labs56.Lab5.Body2D;
      parameter Modelica.SIunits.Length R = 1;  
      
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape WheelShape(shapeType = "cylinder", length = 0.1, width = 2*R, height = 2*R, lengthDirection = {0, 0, 1}, widthDirection = {cos(Phi), sin(Phi), 0}, color = Color, specularCoefficient = 0.5, r = {X, Y, 0}, R = orientation, r_shape = {0, 0, 0});
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape WheelShape2(shapeType = "box", length = 0.2, width = R, height = R, lengthDirection = {0, 0, 1}, widthDirection = {cos(Phi), sin(Phi), 0}, color = Color*0.5, specularCoefficient = 0.5, r = {X, Y, 0}, R = orientation, r_shape = {0, 0, 0});
    equation
    
    end Wheel2D;
  
    model RollWheelOnLine
  
      parameter Modelica.SIunits.Length Xp = 0;
      parameter Modelica.SIunits.Length Yp = 0;
      parameter Modelica.SIunits.Angle Phip = 0;
      
      Modelica.SIunits.Length S;
      
      parameter Modelica.SIunits.Length R = 1;
      
      
      parameter Real Color[3] = {100, 0, 0};
      parameter Modelica.Mechanics.MultiBody.Frames.Orientation orientation = Modelica.Mechanics.MultiBody.Frames.axesRotations({1, 2, 3}, {0, 0, 0}, {0, 0, 0});
      
      parameter Modelica.SIunits.Length L_Box = 5;
      Modelica.Mechanics.MultiBody.Visualizers.Advanced.Shape GroundBox(shapeType = "box", length = L_Box, width = 0.15, height = 0.15, lengthDirection = {cos(Phip), sin(Phip), 0}, widthDirection = {0, 0, 1}, color = Color, specularCoefficient = 0.5, r = {Xp - L_Box / 2 * cos(Phip), Yp - L_Box / 2 * sin(Phip), 0}, R = orientation, r_shape = {0, 0, 0});
      
      KinematicInput Body_In;
      
    equation
    
      Xp + S*cos(Phip) = Body_In.X + R * sin(Phip);
      
      Yp + S*sin(Phip) = Body_In.Y - R * cos(Phip);
      
      der(S) = - der(Body_In.Phi) * R;
      
    end RollWheelOnLine;
  
    model DvePalkiSKolesom
  parameter Modelica.SIunits.Length L1 = 2;
      parameter Modelica.SIunits.Length L2 = 5;
      parameter Modelica.SIunits.Length R = 0.75;
      parameter Modelica.SIunits.Angle Phi10 = 0;
      parameter Modelica.SIunits.Angle Phi20 = 0;
      parameter Modelica.SIunits.Angle PhiP = 0;
      parameter Modelica.SIunits.Length XO = 0;
      parameter Modelica.SIunits.Length YO = 0;
      parameter Modelica.SIunits.Length XP = XO + L1*cos(Phi10) + L2*cos(Phi20) + R*sin(PhiP);
      parameter Modelica.SIunits.Length YP = YO + L1*sin(Phi10) + L2*sin(Phi20) - R*cos(PhiP);
      
      Rod2D Palka1(Color = {255, 0, 0}, L = L1, Phi(start = Phi10));
      Rod2D Palka2(Color = {0, 255, 0}, L = L2, Phi(start = Phi20));
      Wheel2D Koleso(Color = {0, 0, 255}, R = R);
      Support2D Opora(Xp = XO, Yp = YO, Xt = -L1 / 2, Yt = 0);
      Joint2D Ssharnir1(Xt1 = L1 / 2, Yt1 = 0, Xt2 = -L2 / 2, Yt2 = 0);
      Joint2D Ssharnir2(Xt1 = L2 / 2, Yt1 = 0, Xt2 = 0, Yt2 = 0);
      RollWheelOnLine Roll(Xp = XP, Yp = YP, Phip = PhiP, R = R);
      
    equation
    
      connect(Palka1.Body_Out, Opora.Body_In);
      connect(Palka1.Body_Out, Ssharnir1.Body1_In);
      connect(Palka2.Body_Out, Ssharnir1.Body2_In);
      connect(Palka2.Body_Out, Ssharnir2.Body1_In);
      connect(Koleso.Body_Out, Ssharnir2.Body2_In);
      connect(Koleso.Body_Out, Roll.Body_In);
      
      Palka1.Phi = time;
      
      annotation(
        experiment(StartTime = 0, StopTime = 10, Tolerance = 1e-06, Interval = 0.0002));
    end DvePalkiSKolesom;
  
    model Variant3
    
      parameter Modelica.SIunits.Length L1 = 2;
      parameter Modelica.SIunits.Length L2 = 6;
      parameter Modelica.SIunits.Length L3 = 6;
      parameter Modelica.SIunits.Length L4 = 6;
      parameter Modelica.SIunits.Length R = 2;
      parameter Modelica.SIunits.Angle Phi10 = 2.3;
      parameter Modelica.SIunits.Angle Phi20 = 1.8;
      parameter Modelica.SIunits.Angle Phi30 = 0;
      parameter Modelica.SIunits.Angle Phi40 = - 1.3;
      parameter Modelica.SIunits.Angle PhiK = 0;
      parameter Modelica.SIunits.Angle PhiP = - 1.5708;
      parameter Modelica.SIunits.Length XO = -5;
      parameter Modelica.SIunits.Length YO = -5;
      parameter Modelica.SIunits.Length XP = XO + L1 * cos(Phi10) + L2 * cos(Phi20) + L3 * cos(Phi30)* 4/5;
      parameter Modelica.SIunits.Length YP = YO + L1 * sin(Phi10) + L2 * sin(Phi20) + L3 * sin(Phi30)* 4/5;
      parameter Modelica.SIunits.Length XP1 = XO + L1 * cos(Phi10) + L2 * cos(Phi20) + L3 * cos(Phi30)+ L4 * cos(Phi40) - R * cos (PhiK);
      parameter Modelica.SIunits.Length YP1 = YO + L1 * sin(Phi10) + L2 * sin(Phi20) + L3 * sin(Phi30) + L4 * sin(Phi40) - R* sin(PhiK);
      
      Rod2D Palka1(Color = {255, 0, 0}, L = L1, Phi(start = Phi10));
      Rod2D Palka2(Color = {0, 255, 0}, L = L2, Phi(start = Phi20));
      Rod2D Palka3(Color = {0, 0, 255}, L = L3, Phi(start = Phi30));
      Rod2D Palka4(Color = {255, 255, 0}, L = L4, Phi(start = Phi40));
      Support2D Opora1(Xp = XO, Yp = YO, Xt = -L1/2, Yt = 0);
      Joint2D Ssharnir1(Xt1 = L1 / 2, Yt1 = 0, Xt2 = -L2 / 2, Yt2 = 0);
      Joint2D Ssharnir2(Xt1 = L2 / 2, Yt1 = 0, Xt2 = -L3 / 2, Yt2 = 0);
      Support2D Opora2(Xp = XP, Yp = YP, Xt = L3 / 5, Yt = 0);
      Joint2D Ssharnir3(Xt1 = L3 / 2, Yt1 = 0, Xt2 = -L4 / 2, Yt2 = 0);
      Joint2D Ssharnir4(Xt1 = L4 / 2, Yt1 = 0, Xt2 = 0, Yt2 = 0);
      Wheel2D Koleso(Color = {0, 0, 255}, R = R, Phi(start = PhiK));
      RollWheelOnLine Roll(Xp = XP1, Yp = YP1, Phip = PhiP, R = R);
      
    equation
      connect(Palka1.Body_Out, Opora1.Body_In);
      connect(Palka1.Body_Out, Ssharnir1.Body1_In);
      connect(Palka2.Body_Out, Ssharnir1.Body2_In);
      connect(Palka2.Body_Out, Ssharnir2.Body1_In);
      connect(Palka3.Body_Out, Ssharnir2.Body2_In);
      connect(Palka3.Body_Out, Opora2.Body_In);
      connect(Palka3.Body_Out, Ssharnir3.Body1_In);
      connect(Palka4.Body_Out, Ssharnir3.Body2_In);
      connect(Palka4.Body_Out, Ssharnir4.Body1_In);
      connect(Koleso.Body_Out, Ssharnir4.Body2_In);
      connect(Koleso.Body_Out, Roll.Body_In);
      der(Palka1.Phi) = 1;
      
      annotation(
        experiment(StartTime = 0, StopTime = 50, Tolerance = 1e-06, Interval = 0.001));
        
    end Variant3;
  end Lab5;
end Labs56;
