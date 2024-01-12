#include <stdio.h>
#include <string.h>


int main()
{
    //email address and email verification
    char email[250];
    char email2[250];
    printf("Enter your email address: ");
    scanf("%s", email);
    printf("Enter your email address again: ");
    scanf("%s", email2);
    if (strcmp(email, email2) == 0)
    {
        printf("Emails match\n");
    }
    else
    {
        printf("Emails do not match\n");
    }
    return 0;
}