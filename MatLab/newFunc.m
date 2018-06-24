
function [] = newFunc()
mercury= csvread('test.csv',10,0);
venus= csvread('Venus.csv',10, 0);
earth= csvread('earth.csv',10,0);
mars= csvread('mars.csv',10,0);
jupiter= csvread('jupiter.csv',10,0);
saturn= csvread('saturn.csv',10,0);
uranus= csvread('uranus.csv',10,0);
neptune= csvread('neptune.csv',10,0);
pluto= csvread('pluto.csv',10,0);


MercuryX = mercury(10:395,1);
MercuryY = mercury(10:395,2);

VenusX = venus(10:395,1);
VenusY = venus(10:395,2);

EarthX=earth(10:395,1);
EarthY=earth(10:395,2);

MarsX=mars(10:395,1);
MarsY=mars(10:395,2);

JupiterX=jupiter(10:395,1);
JupiterY=jupiter(10:395,2);

SaturnX=saturn(10:395,1);
SaturnY=saturn(10:395,2);

UranusX=uranus(10:395,1);
UranusY=uranus(10:395,2);

NeptuneX=neptune(10:395,1);
NeptuneY=neptune(10:395,2);

plutoX=pluto(10:395,1);
plutoY=pluto(10:395,2);


 plot(MercuryX,MercuryY,VenusX,VenusY,EarthX,EarthY,MarsX,MarsY,JupiterX,JupiterY,SaturnX,SaturnY,UranusX,UranusY,NeptuneX,NeptuneY,plutoX,plutoY);

legend('Mercury','Venus','Earth','Mars','Jupiter','Saturn','Uranus','Neptune','Pluto');






