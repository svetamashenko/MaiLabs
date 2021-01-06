t=0:0.01:20; %������ ������ �������
x0=3;
x=x0+cos(3*t); %����� ����� ��������� ���������
phi=-sin(3*t); %������, ����� ������� ����
h=4; %������ ������
L=9; %����� �����
R=0.25; %������ ����
a=4; %������ ������
b=1; %������ ������
l=3; %����� ��������
N=10; %����� ������� �������
Nv=3; %����� ������ ���������� �������
r1=b/3; %���������� ������ ���������� �������
r2=2*b/3; %������� ������ ���������� �������

% ��������� ����
figure %�������������� �������� ����
xlim([-1 10]) %������� �������� �� x
ylim([-2 6]) %� �� y
xlim manual %� ����������, ����� �� ��� ��������
ylim manual %�� �������.
axis equal %����� 1 �� x ��������� �����, ��� � 1 �� y
hold on %����� �� ������������ ����������� �� ����� �������
plot([0 0],[0 h],'color',[0 0 0],'lineWidth',2); %������
plot([0 L],[0 0],'color',[0 0 0],'lineWidth',2); %� ���

TelegsX=[0 0 a a 0]; %�������� "�������"
TelegsY=[2.5*R 2.5*R+b 2.5*R+b 2.5*R 2.5*R]; %�������
Telega=plot(TelegsX+x(1),TelegsY,'color',[0 0 1],'lineWidth',2); %� � ���������
xA=x+a/2; %��� �������� ���������
yA=2.5*R+b/2; %���������� ����� A
xB=xA+l*sin(phi); %� B
yB=yA+l*cos(phi);
AB=plot([xA(1) xB(1)],[yA yB(1)],'color',[0 0 0]); %������ �����
PointA=plot(xA(1),yA,'o','markerFaceColor',[1 0 0],'color',[0 0 0]); %� �����
PointB=plot(xB(1),yB(1),'o','markersize',20,'markerFaceColor',[0 1 0],'color',[0 0 0]);

p=0:0.1:6.3; %��� ��������� ���� ������ "������"
Xk0=R*cos(p); %���������� ������� R
Yk0=R*sin(p);
K1=plot(Xk0+x(1)+a/5,Yk0+R,'color',[1 0 0]); %� ������ �, ������� �����
K2=plot(Xk0+x(1)+4*a/5,Yk0+R,'color',[1 0 0]); %� �� ������ ������� ��� ��
D1=plot([-R*cos(x(1)/R) R*cos(x(1)/R)]+x(1)+4*a/5,[R*sin(x(1)/R) -R*sin(x(1)/R)]+R,'color',[0 0 1]); %����� ������, ��� ����� ��������,
D2=plot([R*sin(x(1)/R) -R*sin(x(1)/R)]+x(1)+a/5,[R*cos(x(1)/R) -R*cos(x(1)/R)]+R,'color',[0 0 1]); %�������� ���������� �������� (���� �������� = x/R)

V0x=[a/5-R/2 a/5 a/5+R/2]; %������ "������"
V0y=[2.5*R R 2.5*R]; %�������� ������
V1=plot(V0x+x(1),V0y,'color',[0 0 1],'lineWidth',2); %� ������
V2=plot(V0x+x(1)+3*a/5,V0y,'color',[0 0 1],'lineWidth',2); %��� ��������
for i=1:N %� ���� ����� ������ "������" �������
  if i==1 %������ 1, ����� ����� ������ ��������� �� x
    Xpr(i)=0; %���� ����� ��������� ���������
    Ypr(i)=2.5*R+b/2; %�� ��������� � ���, ��� �� �������
  elseif i==N %�� �������
    Xpr(i)=1;
    Ypr(i)=2.5*R+b/2;
  else
    Xpr(i)=(i-1.5)*1/(N-2);
    Ypr(i)=2.5*R+b/2+b/4*(-1)^i;
  end
end

Pruzzhina=plot(Xpr*x(1),Ypr,'color',[0 0.5 0]); %������ ��������
Pr0=plot(0,Ypr(1),'o','color',[0 0.5 0],'markerFaceColor',[0 1 0]); %� �������� ��������
Pr1=plot(x(1),Ypr(N),'o','color',[0 0.5 0],'markerFaceColor',[0 1 0]); %� ������ � �����
alpha=0:0.01:2*pi*Nv-phi(1); %���������� ��������, ��� ��� �� ������ ������
RPr=r1+(r2-r1)*alpha/(2*pi*Nv-phi(1)); %� ���������� �������������
XSPr=-RPr.*sin(alpha); %��� �� ��� � ����������
YSPr=RPr.*cos(alpha);
SPruzzhina=plot(XSPr+xA(1),YSPr+yA,'color',[0.5 0 0]); %������ �������
SPr0=plot(XSPr(1)+xA(1),YSPr(1)+yA,'o','color',[0.5 0 0],'markerFaceColor',[0 1 0]); %� ������
SPr1=plot(XSPr(length(alpha))+xA(1),YSPr(length(alpha))+yA,'o','color',[0.5 0 0],'markerFaceColor',[0 1 0]);

for i=1:length(t)
  set(Telega,'Xdata',TelegsX+x(i)); %������� ������
  set(PointA,'Xdata',xA(i)); %��������� �����
  set(PointB,'Xdata',xB(i),'Ydata',yB(i)); %����� ��������
  set(AB,'Xdata',[xA(i) xB(i)],'Ydata',[yA yB(i)]); %����� ��������
  set(K1,'Xdata',Xk0+x(i)+a/5); %������ ���
  set(K2,'Xdata',Xk0+x(i)+4*a/5); %������ ���
  set(D1,'Xdata',[-R*cos(x(i)/R) R*cos(x(i)/R)]+x(i)+4*a/5,'Ydata',[R*sin(x(i)/R) -R*sin(x(i)/R)]+R); %�������� ����
  set(D2,'Xdata',[R*sin(x(i)/R) -R*sin(x(i)/R)]+x(i)+a/5,'Ydata',[R*cos(x(i)/R) -R*cos(x(i)/R)]+R);
  set(V1,'Xdata',V0x+x(i)); %�������� ����
  set(V2,'Xdata',V0x+x(i)+3*a/5);
  set(Pruzzhina,'Xdata',Xpr*x(i)); %�������
  set(Pr1,'Xdata',x(i)); %������ ����� �������
  alpha=0:0.01:2*pi*Nv-phi(i); %������������� �����
  RPr=r1+(r2-r1)*alpha/(2*pi*Nv-phi(i)); %���������� �������
  XSPr=-RPr.*sin(alpha);
  YSPr=RPr.*cos(alpha);
  set(SPruzzhina,'Xdata',XSPr+xA(i),'Ydata',YSPr+yA); %� ������ ��
  set(SPr0,'Xdata',XSPr(1)+xA(i)); %� ������
  set(SPr1,'Xdata',XSPr(length(alpha))+xA(i),'Ydata',YSPr(length(alpha))+yA); %���
  pause(0.01); %�� �������, �� �������, ���� ���������

end