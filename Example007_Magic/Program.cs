Console.Clear();
int ya = 4, xb = 4;

string s = "x";
Random rnd = new();
int yb = rnd.Next(ya+8, 46);
int yc = rnd.Next(ya+16, 46);
int xc = rnd.Next(xb+20, 150);
int xa = rnd.Next(4, 150);

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
    
