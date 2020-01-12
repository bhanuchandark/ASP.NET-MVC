using System;

namespace SampleEventDelegate
{	
	public class MyEventHandler
	{
		public delegate void MessageHandler(string message);
		
		public event MessageHandler Msg;

        	public void ProcessMessage()
        	{
            		OnMessage("ProcessMessage() begin");
            		OnMessage("ProcessMessage() end");
        	}
 
        	// By Default, create an OnXXXX Method, to call the Event
        	protected void OnMessage(string message)
        	{
            		if (Msg != null)
            		{
                		Msg(message);
            		}
        	}
	}

    	public class TestAppl
    	{
        	public static void DisplayMessage(string s)
        	{
            		Console.WriteLine(s);
        	}

            //Uncomment the following while executing this code.--------
            /*
        	public static void Main(string[] args)
        	{            		
            		MyEventHandler msgHandler = new MyEventHandler();

            		msgHandler.Msg += new MyEventHandler.MessageHandler(DisplayMessage);

            		msgHandler.ProcessMessage();            		
        	}
             * */
    	}	
}