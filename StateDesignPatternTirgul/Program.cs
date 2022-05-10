using StateDesignPatternTirgul;

ContextMessage contextMessage = new ContextMessage();
contextMessage.SendRequest();// the state is send now
contextMessage.ArchieveRequest();// The state is still send
ContextMessage contextMessage1 = new ContextMessage();
contextMessage1.ArchieveRequest();// The state is archieve now
contextMessage1.SendRequest(); // The state is still archieve
contextMessage1.RemoveFromArchieveRequest();// The state is befor send now
contextMessage1.RemoveFromArchieveRequest();



