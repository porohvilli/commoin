public interface IHelpDesk {
    void SomeFunction();
    int AnotherFunction();
    // etc.
}

public class HelpDesk : IHelpDesk {
    public void SomeFunction() {
        // Implementation
    }

    public int AnotherFunction() {
        // Implementation
        return 0;
    }
}
