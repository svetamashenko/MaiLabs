% Массивы и зависимости
t=0:0.01:10;
r=1+sin(8*t);
phi=t+0.5*sin(8*t);
x=r.*cos(phi);
y=r.*sin(phi);
Vx=diff(x); % Массив на 1 короче предыдущих
Vy=diff(y);
Wx=diff(Vx); %массив на 1 короче предыдущих
Wy=diff(Vy);
k=15;
k1=250;
Vphi=atan2(Vy,Vx);
Wphi=atan2(Wy,Wx);

% Косметика окна
figure; % принудительное создание окна
xlim([1.3*min(x) 1.3*max(x)]);
ylim([1.3*min(y) 1.3*max(y)]);
xlim manual;
ylim manual;
axis equal;
hold on;

% Рисовашки
plot(x,y);
P=plot(x(1),y(1),'o', 'markersize', 20, 'markerfacecolor', [0 0 1]);
Vline=plot([x(1) x(1)+Vx(1)*k], [y(1) y(1)+Vy(1)*k], 'color', [1 0 0]);
Wline=plot([x(1) x(1)+k1*Wx(1)],[y(1) y(1)+k1*Wy(1)], 'color', [0 1 0])

function A = Rot2D (Vers, phi)
A(1,:)=Vers(1,:)*cos(phi)-Vers(2,:)*sin(phi);
A(2,:)=Vers(1,:)*sin(phi)+Vers(2,:)*cos(phi);
end

ARR = [-0.1 0 -0.1; 0.05 0 -0.05];
RotARR=Rot2D(ARR,Vphi(1));
VArrow=plot(RotARR(1,:)+k*Vx(1), RotARR(2,:)+y(1)+k*Vy(1), 'color', [1 0 0])

RotARR=Rot2D(ARR,Vphi(1));
WArrow=plot(RotARR(1,:)+x(1)+k*Wx(1),RotARR(2,:)+y(1)+k*Wy(1),'color', [0 1 0])

for i=1:length(t)
  set(P, 'XData', x(i), 'YData', y(i));
  set(Vline, 'XData', [x(i) x(i)+Vx(i)*k], 'YData', [y(i) y(i)+Vy(i)*k]);
  set(Wline,'XData', [x(i) x(i)+k1*Wx(i)],'YData', [y(i) y(i)+k1*Wy(i)]);RotARR=Rot2D(ARR,Vphi(i));
  RotARR=Rot2D(ARR,Vphi(i));
  set(VArrow,'XData', RotARR(1,:)+x(i)+k*Vx(i), 'YData', RotARR(2,:)+y(i)+k*Vy(i));
  RotARR=Rot2D(ARR,Wphi(i));
  set(WArrow,'XData', RotARR(1,:)+x(i)+k1*Wx(i),'YData', RotARR(2,:)+y(i)+k1*Wy(i));
  pause(0.02);
end
