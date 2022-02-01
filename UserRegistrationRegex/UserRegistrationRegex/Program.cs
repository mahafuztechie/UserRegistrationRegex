using UserRegistrationRegex;

UserForm UserRegister = new UserForm();
UserRegister.ValidateFName("Abcdef");
UserRegister.ValidateLName("Xyzabc");
UserRegister.ValidateEmail("abc_456xyz@BridgeLabz.co.in");
UserRegister.ValidateMobile("91 9876543210");
UserRegister.ValidatePasswordR1("abcdefgh");
Console.WriteLine("rule 2 is : "+UserRegister.ValidatePasswordR2());
Console.WriteLine("rule 3 is : "+UserRegister.ValidatePasswordR3());
Console.WriteLine("rule 4 is : " +UserRegister.ValidatePasswordR4());