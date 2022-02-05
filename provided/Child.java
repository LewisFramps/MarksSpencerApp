
package hacktheburgh;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import javax.annotation.Generated;

@Generated("jsonschema2pojo")
public class Child {

    private String text;
    private List<Child__1> children = null;
    private Map<String, Object> additionalProperties = new HashMap<String, Object>();

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public List<Child__1> getChildren() {
        return children;
    }

    public void setChildren(List<Child__1> children) {
        this.children = children;
    }

    public Map<String, Object> getAdditionalProperties() {
        return this.additionalProperties;
    }

    public void setAdditionalProperty(String name, Object value) {
        this.additionalProperties.put(name, value);
    }

}
