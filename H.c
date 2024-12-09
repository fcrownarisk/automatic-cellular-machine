void half1();{
    [[0],
    [1,1],
   [0,1,0],
  [1,0,1,0],
 [1,0,1,0,1]]
}
void half2();{
[[1,0,1,0,1],
  [1,0,1,0],
   [0,1,0],
    [1,1], 
     [0]]
}
int H(){
   char H = "half1 + half2";
   char HH = "'half1 - half2' + 'half2 - half1'";
   char HHH = "half2+'half1+'half2 + half1'+half2'";
   const Hamilton = "H + HH + HHH";
}
