
global m R g;    % требующиеся параметры

m = 1;                %масса груза
R=0.1;                  %радиус цилиндра
g = 9.81;



L=2*R;                    %длина опоры

tstep = 0.01;           %временной шаг
tfin = 10;              %окончание отсчета времени
tout = 0:tstep:tfin;    %временная сетка


y0 = [0.1 pi/2 0 pi/3];
    %y1_0, y2_0, y3_0, y4_0
[t,y]=ode45(@f, tout, y0);

X = y(:,1);
Phi = y(:,2);

plot(t,[X, Phi]);

x=X;
phi=Phi;




% Косметика окна
figure %принудительное создание окна
  xlim([-abs(sqrt(x(1)^2+R^2)*cos(-pi/2+phi(1)+ atan(R/x(1))))-R R+abs(sqrt(x(1)^2+R^2)*cos(-pi/2+phi(1)+ atan(R/x(1))))]);
  ylim([-x(1) 1]);
axis equal %чтобы 1 по x выглядела также, как и 1 по y
hold on %чтобы всё нарисованное сохранялось на одном рисунке
##plot([-L/2 L/2],[0 0],'color',[0 0 0],'lineWidth',2); %потолок


line=plot([0 (x(1))*cos(-pi/2+phi(1))], [0 (x(1))*sin(-pi/2+phi(1))],'color',[1 0 0], 'lineWidth', 2); %нить касается окружности, надо сделать, чтоб пересекал чуть-чуть


p=0:0.01:pi*2;
xk0=R*cos(p);
yk0=R*sin(p);

Cil = plot(xk0+sqrt(x(1)^2+R^2)*cos(-pi/2+phi(1)+ atan(R/x(1))),yk0+sqrt(x(1)^2+R^2)*sin(-pi/2+phi(1)+ atan(R/x(1))),'color',[1 0 0], 'lineWidth', 2);

##Dia=plot([-cos(R)+(sqrt((L+x(1))^2+R*R))*cos(-pi/2+phi(1)) cos(R)+(sqrt((L+x(1))^2+R*R))*cos(-pi/2+phi(1))],[-sin(R)+sqrt((L+x(1))^2+R*R)*sin(-pi/2+phi(1)) sin(R)+sqrt((L+x(1))^2+R*R)*sin(-pi/2+phi(1))]);


Dia=plot([-R*cos(phi(1)-x(1)/R)+sqrt(x(1)^2+R^2)*cos(-pi/2+phi(1)+ atan(R/x(1))) R*cos(phi(1)-x(1)/R)+sqrt(x(1)^2+R^2)*cos(-pi/2+phi(1)+ atan(R/x(1)))],[-R*sin(phi(1)-x(1)/R)+sqrt(x(1)^2+R^2)*sin(-pi/2+phi(1)+ atan(R/x(1))) R*sin(phi(1)-x(1)/R)+sqrt(x(1)^2+R^2)*sin(-pi/2+phi(1)+ atan(R/x(1)))]);



##pause(5)

for i=1:length(t)
  xlim([-abs(sqrt(x(i)^2+R^2)*cos(-pi/2+phi(i)+ atan(R/x(i))))-R R+abs(sqrt(x(i)^2+R^2)*cos(-pi/2+phi(i)+ atan(R/x(i))))]);
  ylim([-x(i) 1]);
  set(line,'Xdata',[0 (x(i))*cos(-pi/2+phi(i))],'Ydata',[0 (x(i))*sin(-pi/2+phi(i))]);
  set(Cil,'Xdata',xk0+sqrt(x(i)^2+R^2)*cos(-pi/2+phi(i)+ atan(R/x(i))),'Ydata',yk0+sqrt(x(i)^2+R^2)*sin(-pi/2+phi(i)+ atan(R/x(i))));
  set(Dia,'Xdata',[-R*cos(phi(i)-x(i)/R)+sqrt(x(i)^2+R^2)*cos(-pi/2+phi(i)+ atan(R/x(i))) R*cos(phi(i)-x(i)/R)+sqrt(x(i)^2+R^2)*cos(-pi/2+phi(i)+ atan(R/x(i)))],'Ydata',[-R*sin(phi(i)-x(i)/R)+sqrt(x(i)^2+R^2)*sin(-pi/2+phi(i)+ atan(R/x(i))) R*sin(phi(i)-x(i)/R)+sqrt(x(i)^2+R^2)*sin(-pi/2+phi(i)+ atan(R/x(i)))])
  pause(0.01); %всё сделано, мы молодцы, пора отдохнуть
  
end