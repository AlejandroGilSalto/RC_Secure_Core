using System;

public class UserInfo
{
	private bool isValidated;
	private String userName = "";

    public bool IsValidated
    {
        get { return isValidated; }
        set { isValidated = value; }
    }

    public String UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public UserInfo()
	{
		isValidated = false;		
	}
}
