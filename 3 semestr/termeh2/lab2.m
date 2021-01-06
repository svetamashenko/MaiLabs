t=0:0.01:20; %создаём массив времени
x0=3;
y0=9;
phi=sin(7.07); %наобум, чтобы красиво было
alp=sin(t);
x=x0+cos(alp);
y=y0-sin(alp); %задаём закон изменения координат

L=9; %длина опоры
R=1; %радиус цилиндра

% Косметика окна
figure %принудительное создание окна
xlim([-1 10]) %задание пределов по x
ylim([-1 10]) %и по y
xlim manual %и требование, чтобы он эти значения
ylim manual %не изменял.
axis equal %чтобы 1 по x выглядела также, как и 1 по y
hold on %чтобы всё нарисованное сохранялось на одном рисунке
plot([0 L],[9 9],'color',[0 0 0],'lineWidth',2); %потолок

xO = 3;
yO = 9;
PointO = plot(xO, yO, 'o','markerFaceColor',[1 0 0],'color',[0 0 0]);

Xn1=xO;
Yn1=yO;
Nitka=plot([Xn1 xO+sin(phi)*x(1)], [Yn1 yO-cos(phi)*y(1)],'color',[0 0 0]);

xA = Xn2;
yA = Yn2;
PointA=plot(xA+x(1),yA+y(1),'o','markerFaceColor',[1 0 0],'color',[0 0 0]);

p=0:0.1:6.3; %для рисования Цилиндра делаем "шаблон"
Xk0=R*cos(p); %окружности радиуса R
Yk0=R*sin(p);
Cilindr=plot(Xk0+x(1)+R/2,Yk0+y(1),'color',[1 0 0]); %и рисуем её
%Dia=plot([-R*cos(x(1)/R) R*cos(x(1)/R)]+x(1),[R*sin(x(1)/R) -R*sin(x(1)/R)]+R,'color',[0 0 1]); %чтобы видеть, что колёса крутятся,

for i=1:length(t)
  set(PointA,'Xdata',xA+x(i), 'Ydata', yA+y(i));
  set(Nitka, [Xn1 xO+sin(phi)*x(i)], [Yn1 yO-cos(phi)*y(i)]);
  set(Cilindr, 'Xdata', Xk0+x(i)+R/2, 'Ydata', Yk0+y(i)); %цилиндр
  %set(Dia,'Xdata',[-R*cos(x(i)/R) R*cos(x(i)/R)]+x(i),'Ydata',[R*sin(x(i)/R) -R*sin(x(i)/R)]+R); %диаметры колёс
  pause(0.01); %всё сделано, мы молодцы, пора отдохнуть
  
end