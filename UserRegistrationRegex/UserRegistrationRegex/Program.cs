using UserRegistrationRegex;

UserForm UserRegister = new UserForm();
UserRegister.ValidateFName("Abcdef");
UserRegister.ValidateLName("Xyzabc");
UserRegister.ValidateEmail("abc_456xyz@BridgeLabz.co.in");
UserRegister.ValidateMobile("91 9876543210");