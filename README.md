**Principles:**
1. The model should only have properties that are stored in the database.
2. Every use case with business logic should be implemented in an operation.
3. The operation can update one or more properties.
4. The operation can have other child operations.
5. The operation can have other domain objects, such as business rules, calculators, factories, providers, and others.
6. The operation should not have infrastructure dependencies like repository or bus.
7. The operation should be called from the application layer.
   
**Advantages:**
1. Using domain operations allows you to avoid a large domain model and services.
2. Using domain operations allows you to separate each use case into different operations, it improves the readability of the code.
3. Using domain operations allows you to use dependency injection within operations(the rich domain model doesn't have this capability), and domain operations can be injected into application layer. This results in better testability and the ability to mock operations.

**Disadvantages:**
1. The properties of the model and business logic are separated, similar to the anemic domain model approach.
