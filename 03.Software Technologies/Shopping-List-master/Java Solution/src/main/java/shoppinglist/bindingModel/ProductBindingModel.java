package shoppinglist.bindingModel;

import javax.validation.constraints.NotNull;

public class ProductBindingModel {

    private int priority;

    @NotNull
    private String name;

    private int quantity;

    @NotNull
    private String status;

    public int getPriority() {
        return this.priority;
    }

    public void setPriority(int priority) {
        this.priority = priority;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }
}
