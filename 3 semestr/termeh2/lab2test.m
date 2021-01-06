t=0:0.01:20; %создаЄм массив времени
x0=3;
x=x0+cos(3*t); %задаЄм закон изменени€ координат
phi=-sin(3*t); %наобум, чтобы красиво было
h=4; %высота стенки
L=9; %длина опоры
R=0.25; %радиус колЄс
a=4; %ширина телеги
b=1; %высота телеги
l=3; %длина ма€тника
N=10; %число изгибов пружины
Nv=3; %число витков спиральной пружины
r1=b/3; %внутренний радиус спиральной пружины
r2=2*b/3; %внешний радиус спиральной пружины

%  осметика окна
figure %принудительное создание окна
xlim([-1 10]) %задание пределов по x
ylim([-2 6]) %и по y
xlim manual %и требование, чтобы он эти значени€
ylim manual %не измен€л.
axis equal %чтобы 1 по x выгл€дела также, как и 1 по y
hold on %чтобы всЄ нарисованное сохран€лось на одном рисунке
plot([0 0],[0 h],'color',[0 0 0],'lineWidth',2); %стенка
plot([0 L],[0 0],'color',[0 0 0],'lineWidth',2); %и пол

TelegsX=[0 0 a a 0]; %создание "шаблона"
TelegsY=[2.5*R 2.5*R+b 2.5*R+b 2.5*R 2.5*R]; %тележки
Telega=plot(TelegsX+x(1),TelegsY,'color',[0 0 1],'lineWidth',2); %и еЄ отрисовка
xA=x+a/2; %дл€ удобства посчитаем
yA=2.5*R+b/2; %координаты точки A
xB=xA+l*sin(phi); %и B
yB=yA+l*cos(phi);
AB=plot([xA(1) xB(1)],[yA yB(1)],'color',[0 0 0]); %рисуем палку
PointA=plot(xA(1),yA,'o','markerFaceColor',[1 0 0],'color',[0 0 0]); %и точки
PointB=plot(xB(1),yB(1),'o','markersize',20,'markerFaceColor',[0 1 0],'color',[0 0 0]);

p=0:0.1:6.3; %дл€ рисовани€ колЄс делаем "шаблон"
Xk0=R*cos(p); %окружности радиуса R
Yk0=R*sin(p);
K1=plot(Xk0+x(1)+a/5,Yk0+R,'color',[1 0 0]); %и рисуем еЄ, сместив центр
K2=plot(Xk0+x(1)+4*a/5,Yk0+R,'color',[1 0 0]); %и со вторым колесом так же
D1=plot([-R*cos(x(1)/R) R*cos(x(1)/R)]+x(1)+4*a/5,[R*sin(x(1)/R) -R*sin(x(1)/R)]+R,'color',[0 0 1]); %чтобы видеть, что колЄса крут€тс€,
D2=plot([R*sin(x(1)/R) -R*sin(x(1)/R)]+x(1)+a/5,[R*cos(x(1)/R) -R*cos(x(1)/R)]+R,'color',[0 0 1]); %нарисуем верт€щиес€ диаметры (угол поворота = x/R)

V0x=[a/5-R/2 a/5 a/5+R/2]; %делаем "шаблон"
V0y=[2.5*R R 2.5*R]; %держалки колеса
V1=plot(V0x+x(1),V0y,'color',[0 0 1],'lineWidth',2); %и рисуем
V2=plot(V0x+x(1)+3*a/5,V0y,'color',[0 0 1],'lineWidth',2); %две держалки
for i=1:N %в этом цикле создаЄм "шаблон" пружины
  if i==1 %длиной 1, потом будем просто домножать на x
    Xpr(i)=0; %этот кусок претерпел изменени€
    Ypr(i)=2.5*R+b/2; %по сравнению с тем, что мы сделали
  elseif i==N %на зан€тии
    Xpr(i)=1;
    Ypr(i)=2.5*R+b/2;
  else
    Xpr(i)=(i-1.5)*1/(N-2);
    Ypr(i)=2.5*R+b/2+b/4*(-1)^i;
  end
end

Pruzzhina=plot(Xpr*x(1),Ypr,'color',[0 0.5 0]); %рисуем пружинку
Pr0=plot(0,Ypr(1),'o','color',[0 0.5 0],'markerFaceColor',[0 1 0]); %и отмечаем бл€мб€ми
Pr1=plot(x(1),Ypr(N),'o','color',[0 0.5 0],'markerFaceColor',[0 1 0]); %еЄ начало и конец
alpha=0:0.01:2*pi*Nv-phi(1); %спиральна€ пружинка, это уже не просто шаблон
RPr=r1+(r2-r1)*alpha/(2*pi*Nv-phi(1)); %еЄ приходитс€ пересчитывать
XSPr=-RPr.*sin(alpha); %чем мы тут и занимаемс€
YSPr=RPr.*cos(alpha);
SPruzzhina=plot(XSPr+xA(1),YSPr+yA,'color',[0.5 0 0]); %рисуем пружину
SPr0=plot(XSPr(1)+xA(1),YSPr(1)+yA,'o','color',[0.5 0 0],'markerFaceColor',[0 1 0]); %и бл€мбы
SPr1=plot(XSPr(length(alpha))+xA(1),YSPr(length(alpha))+yA,'o','color',[0.5 0 0],'markerFaceColor',[0 1 0]);

for i=1:length(t)
  set(Telega,'Xdata',TelegsX+x(i)); %двигаем телегу
  set(PointA,'Xdata',xA(i)); %крепление палки
  set(PointB,'Xdata',xB(i),'Ydata',yB(i)); %конец ма€тника
  set(AB,'Xdata',[xA(i) xB(i)],'Ydata',[yA yB(i)]); %палку ма€тника
  set(K1,'Xdata',Xk0+x(i)+a/5); %колесо раз
  set(K2,'Xdata',Xk0+x(i)+4*a/5); %колесо два
  set(D1,'Xdata',[-R*cos(x(i)/R) R*cos(x(i)/R)]+x(i)+4*a/5,'Ydata',[R*sin(x(i)/R) -R*sin(x(i)/R)]+R); %диаметры колЄс
  set(D2,'Xdata',[R*sin(x(i)/R) -R*sin(x(i)/R)]+x(i)+a/5,'Ydata',[R*cos(x(i)/R) -R*cos(x(i)/R)]+R);
  set(V1,'Xdata',V0x+x(i)); %держалки колЄс
  set(V2,'Xdata',V0x+x(i)+3*a/5);
  set(Pruzzhina,'Xdata',Xpr*x(i)); %пружину
  set(Pr1,'Xdata',x(i)); %бл€мбу конца пружины
  alpha=0:0.01:2*pi*Nv-phi(i); %пересчитываем точки
  RPr=r1+(r2-r1)*alpha/(2*pi*Nv-phi(i)); %спиральной пружины
  XSPr=-RPr.*sin(alpha);
  YSPr=RPr.*cos(alpha);
  set(SPruzzhina,'Xdata',XSPr+xA(i),'Ydata',YSPr+yA); %и мен€ем их
  set(SPr0,'Xdata',XSPr(1)+xA(i)); %и бл€мбы
  set(SPr1,'Xdata',XSPr(length(alpha))+xA(i),'Ydata',YSPr(length(alpha))+yA); %обе
  pause(0.01); %всЄ сделано, мы молодцы, пора отдохнуть

end