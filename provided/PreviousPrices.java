
package hacktheburgh;

import java.util.HashMap;
import java.util.Map;
import javax.annotation.Generated;

@Generated("jsonschema2pojo")
public class PreviousPrices {

    private Object minimum;
    private Object maximum;
    private Map<String, Object> additionalProperties = new HashMap<String, Object>();

    public Object getMinimum() {
        return minimum;
    }

    public void setMinimum(Object minimum) {
        this.minimum = minimum;
    }

    public Object getMaximum() {
        return maximum;
    }

    public void setMaximum(Object maximum) {
        this.maximum = maximum;
    }

    public Map<String, Object> getAdditionalProperties() {
        return this.additionalProperties;
    }

    public void setAdditionalProperty(String name, Object value) {
        this.additionalProperties.put(name, value);
    }

}
