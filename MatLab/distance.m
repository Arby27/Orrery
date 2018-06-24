function [] = distance()
mercury= csvread('MercuryDistance.csv');
venus= csvread('VenusDistance.csv');
earth= csvread('earthDistance.csv');
mars= csvread('marsDistance.csv');
jupiter= csvread('jupiterDistance.csv');
saturn= csvread('saturnDistance.csv');
uranus= csvread('uranusMovement.csv');
neptune= csvread('NetpuneDistance.csv');
pluto= csvread('plutoDistance.csv');


MercuryX = mercury(:,2);
MercuryY = mercury(:,1);

VenusX = venus(:,2);
VenusY = venus(:,1);

EarthX=earth(:,2);
EarthY=earth(:,1);

MarsX=mars(:,2);
MarsY=mars(:,1);

JupiterX=jupiter(:,2);
JupiterY=jupiter(:,1);

SaturnX=saturn(:,2);
SaturnY=saturn(:,1);

UranusX=uranus(:,2);
UranusY=uranus(:,1);

neptuneX=neptune(:,2);
neptuneY=neptune(:,1);

plutoX=pluto(:,2);
plutoY=pluto(:,1);


 plot(MercuryX,MercuryY,VenusX,VenusY,EarthX,EarthY,MarsX,MarsY,JupiterX,JupiterY,SaturnX,SaturnY,UranusX,UranusY,neptuneX,neptuneY,plutoX,plutoY);

legend('Mercury','Venus','Earth','Mars','Jupiter','Saturn','Uranus','Neptune','Pluto');
xlabel('Time(Days)');
ylabel('Distance(KM)');

