#include <stdio.h>


//first example

int conv(int a)
{
    return a / 9.81 * 3.17;
}

//second example
float GRAVITY_ON_EARTH = 9.81;
float GRAVITY_ON_MARS = 3.711;

float calculate_weight_on_mars (float weight_on_earth)
{
    return (weight_on_earth / GRAVITY_ON_EARTH) * GRAVITY_ON_MARS;
}

//driver code
int main(void)
{
    int weight_on_earth = 80;
    int weight_on_mars = conv(weight_on_earth);
    printf("Weight on Earth: %d\n", weight_on_earth);
    printf("Weight on Mars: %d\n", weight_on_mars);

    printf("\n");

    float weight_on_earth2 = 80;
    float weight_on_mars2 = calculate_weight_on_mars(weight_on_earth2);
    printf("Weight on Earth: %.2f\n", weight_on_earth2);
    printf("Weight on Mars: %.2f\n", weight_on_mars2);
}

// Credit: Michael Parker https://mastodon.social/@michaelparker