
package hacktheburgh;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import javax.annotation.Generated;

@Generated("jsonschema2pojo")
public class ProductDatum {

    private Integer id;
    private String title;
    private String summary;
    private Integer prepTimeMins;
    private Integer cookTimeMins;
    private Integer servings;
    private Integer difficulty;
    private String photoCropFileName;
    private String photoCropContentType;
    private Integer photoCropFileSize;
    private String photoCropUpdatedAt;
    private Integer photoCropHeight;
    private Integer photoCropWidth;
    private String slug;
    private String publishedAt;
    private String source;
    private String course;
    private String youtubeUrl;
    private List<String> ingredients = null;
    private Nutrition nutrition;
    private List<String> recipeSteps = null;
    private Map<String, Object> additionalProperties = new HashMap<String, Object>();

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getSummary() {
        return summary;
    }

    public void setSummary(String summary) {
        this.summary = summary;
    }

    public Integer getPrepTimeMins() {
        return prepTimeMins;
    }

    public void setPrepTimeMins(Integer prepTimeMins) {
        this.prepTimeMins = prepTimeMins;
    }

    public Integer getCookTimeMins() {
        return cookTimeMins;
    }

    public void setCookTimeMins(Integer cookTimeMins) {
        this.cookTimeMins = cookTimeMins;
    }

    public Integer getServings() {
        return servings;
    }

    public void setServings(Integer servings) {
        this.servings = servings;
    }

    public Integer getDifficulty() {
        return difficulty;
    }

    public void setDifficulty(Integer difficulty) {
        this.difficulty = difficulty;
    }

    public String getPhotoCropFileName() {
        return photoCropFileName;
    }

    public void setPhotoCropFileName(String photoCropFileName) {
        this.photoCropFileName = photoCropFileName;
    }

    public String getPhotoCropContentType() {
        return photoCropContentType;
    }

    public void setPhotoCropContentType(String photoCropContentType) {
        this.photoCropContentType = photoCropContentType;
    }

    public Integer getPhotoCropFileSize() {
        return photoCropFileSize;
    }

    public void setPhotoCropFileSize(Integer photoCropFileSize) {
        this.photoCropFileSize = photoCropFileSize;
    }

    public String getPhotoCropUpdatedAt() {
        return photoCropUpdatedAt;
    }

    public void setPhotoCropUpdatedAt(String photoCropUpdatedAt) {
        this.photoCropUpdatedAt = photoCropUpdatedAt;
    }

    public Integer getPhotoCropHeight() {
        return photoCropHeight;
    }

    public void setPhotoCropHeight(Integer photoCropHeight) {
        this.photoCropHeight = photoCropHeight;
    }

    public Integer getPhotoCropWidth() {
        return photoCropWidth;
    }

    public void setPhotoCropWidth(Integer photoCropWidth) {
        this.photoCropWidth = photoCropWidth;
    }

    public String getSlug() {
        return slug;
    }

    public void setSlug(String slug) {
        this.slug = slug;
    }

    public String getPublishedAt() {
        return publishedAt;
    }

    public void setPublishedAt(String publishedAt) {
        this.publishedAt = publishedAt;
    }

    public String getSource() {
        return source;
    }

    public void setSource(String source) {
        this.source = source;
    }

    public String getCourse() {
        return course;
    }

    public void setCourse(String course) {
        this.course = course;
    }

    public String getYoutubeUrl() {
        return youtubeUrl;
    }

    public void setYoutubeUrl(String youtubeUrl) {
        this.youtubeUrl = youtubeUrl;
    }

    public List<String> getIngredients() {
        return ingredients;
    }

    public void setIngredients(List<String> ingredients) {
        this.ingredients = ingredients;
    }

    public Nutrition getNutrition() {
        return nutrition;
    }

    public void setNutrition(Nutrition nutrition) {
        this.nutrition = nutrition;
    }

    public List<String> getRecipeSteps() {
        return recipeSteps;
    }

    public void setRecipeSteps(List<String> recipeSteps) {
        this.recipeSteps = recipeSteps;
    }

    public Map<String, Object> getAdditionalProperties() {
        return this.additionalProperties;
    }

    public void setAdditionalProperty(String name, Object value) {
        this.additionalProperties.put(name, value);
    }

}
