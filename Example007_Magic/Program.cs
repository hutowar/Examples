Console.Clear();

string s = "x";
/* int rnb;
if (xa <= xb) rnb = xa;
else rnb = xb;
int rn1 = new Random().Next(rnb, 4); */

int xa = 4, ya = 4,
    xb = 4, yb = 25,
    xc = 70, yc = 25;

Console.SetCursorPosition(xa, ya);
Console.Write(s);

Console.SetCursorPosition(xb, yb);
Console.Write(s);

Console.SetCursorPosition(xc, yc);
Console.Write(s); 

int x = xa, y = xb;

int count = 0;
while (count < 1000) {
    int nr  = new Random().Next(0, 3); // 0 1 2
    if (nr == 0){
        x = (x + xa) / 2;
        y = (y + ya) / 2; 
    } 
    if (nr == 1){
        x = (x + xb) / 2;
        y = (y + yb) / 2; 
    } 
    if (nr == 2){
        x = (x + xc) / 2;
        y = (y + yc) / 2; 
    } 
    Console.SetCursorPosition(x, y);
    Console.Write(s);
    count++;
}