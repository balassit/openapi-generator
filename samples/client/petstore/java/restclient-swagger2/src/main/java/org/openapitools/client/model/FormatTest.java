/*
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.File;
import java.math.BigDecimal;
import java.time.LocalDate;
import java.time.OffsetDateTime;
import java.util.UUID;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;
import com.fasterxml.jackson.annotation.JsonTypeName;

/**
 * FormatTest
 */
@JsonPropertyOrder({
  FormatTest.JSON_PROPERTY_INTEGER,
  FormatTest.JSON_PROPERTY_INT32,
  FormatTest.JSON_PROPERTY_INT64,
  FormatTest.JSON_PROPERTY_NUMBER,
  FormatTest.JSON_PROPERTY_FLOAT,
  FormatTest.JSON_PROPERTY_DOUBLE,
  FormatTest.JSON_PROPERTY_DECIMAL,
  FormatTest.JSON_PROPERTY_STRING,
  FormatTest.JSON_PROPERTY_BYTE,
  FormatTest.JSON_PROPERTY_BINARY,
  FormatTest.JSON_PROPERTY_DATE,
  FormatTest.JSON_PROPERTY_DATE_TIME,
  FormatTest.JSON_PROPERTY_DURATION,
  FormatTest.JSON_PROPERTY_UUID,
  FormatTest.JSON_PROPERTY_PASSWORD,
  FormatTest.JSON_PROPERTY_PATTERN_WITH_DIGITS,
  FormatTest.JSON_PROPERTY_PATTERN_WITH_DIGITS_AND_DELIMITER
})
@JsonTypeName("format_test")
@jakarta.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", comments = "Generator version: 7.12.0-SNAPSHOT")
public class FormatTest {
  public static final String JSON_PROPERTY_INTEGER = "integer";
  @jakarta.annotation.Nullable
  private Integer integer;

  public static final String JSON_PROPERTY_INT32 = "int32";
  @jakarta.annotation.Nullable
  private Integer int32;

  public static final String JSON_PROPERTY_INT64 = "int64";
  @jakarta.annotation.Nullable
  private Long int64;

  public static final String JSON_PROPERTY_NUMBER = "number";
  @jakarta.annotation.Nonnull
  private BigDecimal number;

  public static final String JSON_PROPERTY_FLOAT = "float";
  @jakarta.annotation.Nullable
  private Float _float;

  public static final String JSON_PROPERTY_DOUBLE = "double";
  @jakarta.annotation.Nullable
  private Double _double;

  public static final String JSON_PROPERTY_DECIMAL = "decimal";
  @jakarta.annotation.Nullable
  private BigDecimal decimal;

  public static final String JSON_PROPERTY_STRING = "string";
  @jakarta.annotation.Nullable
  private String string;

  public static final String JSON_PROPERTY_BYTE = "byte";
  @jakarta.annotation.Nonnull
  private byte[] _byte;

  public static final String JSON_PROPERTY_BINARY = "binary";
  @jakarta.annotation.Nullable
  private File binary;

  public static final String JSON_PROPERTY_DATE = "date";
  @jakarta.annotation.Nonnull
  private LocalDate date;

  public static final String JSON_PROPERTY_DATE_TIME = "dateTime";
  @jakarta.annotation.Nullable
  private OffsetDateTime dateTime;

  public static final String JSON_PROPERTY_DURATION = "duration";
  @jakarta.annotation.Nonnull
  private String duration;

  public static final String JSON_PROPERTY_UUID = "uuid";
  @jakarta.annotation.Nullable
  private UUID uuid;

  public static final String JSON_PROPERTY_PASSWORD = "password";
  @jakarta.annotation.Nonnull
  private String password;

  public static final String JSON_PROPERTY_PATTERN_WITH_DIGITS = "pattern_with_digits";
  @jakarta.annotation.Nullable
  private String patternWithDigits;

  public static final String JSON_PROPERTY_PATTERN_WITH_DIGITS_AND_DELIMITER = "pattern_with_digits_and_delimiter";
  @jakarta.annotation.Nullable
  private String patternWithDigitsAndDelimiter;

  public FormatTest() {
  }

  public FormatTest integer(@jakarta.annotation.Nullable Integer integer) {
    
    this.integer = integer;
    return this;
  }

  /**
   * Get integer
   * minimum: 10
   * maximum: 100
   * @return integer
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_INTEGER)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public Integer getInteger() {
    return integer;
  }


  @JsonProperty(JSON_PROPERTY_INTEGER)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setInteger(@jakarta.annotation.Nullable Integer integer) {
    this.integer = integer;
  }

  public FormatTest int32(@jakarta.annotation.Nullable Integer int32) {
    
    this.int32 = int32;
    return this;
  }

  /**
   * Get int32
   * minimum: 20
   * maximum: 200
   * @return int32
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_INT32)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public Integer getInt32() {
    return int32;
  }


  @JsonProperty(JSON_PROPERTY_INT32)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setInt32(@jakarta.annotation.Nullable Integer int32) {
    this.int32 = int32;
  }

  public FormatTest int64(@jakarta.annotation.Nullable Long int64) {
    
    this.int64 = int64;
    return this;
  }

  /**
   * Get int64
   * @return int64
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_INT64)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public Long getInt64() {
    return int64;
  }


  @JsonProperty(JSON_PROPERTY_INT64)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setInt64(@jakarta.annotation.Nullable Long int64) {
    this.int64 = int64;
  }

  public FormatTest number(@jakarta.annotation.Nonnull BigDecimal number) {
    
    this.number = number;
    return this;
  }

  /**
   * Get number
   * minimum: 32.1
   * maximum: 543.2
   * @return number
   */
  @jakarta.annotation.Nonnull
  @Schema(requiredMode = Schema.RequiredMode.REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_NUMBER)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public BigDecimal getNumber() {
    return number;
  }


  @JsonProperty(JSON_PROPERTY_NUMBER)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setNumber(@jakarta.annotation.Nonnull BigDecimal number) {
    this.number = number;
  }

  public FormatTest _float(@jakarta.annotation.Nullable Float _float) {
    
    this._float = _float;
    return this;
  }

  /**
   * Get _float
   * minimum: 54.3
   * maximum: 987.6
   * @return _float
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_FLOAT)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public Float getFloat() {
    return _float;
  }


  @JsonProperty(JSON_PROPERTY_FLOAT)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setFloat(@jakarta.annotation.Nullable Float _float) {
    this._float = _float;
  }

  public FormatTest _double(@jakarta.annotation.Nullable Double _double) {
    
    this._double = _double;
    return this;
  }

  /**
   * Get _double
   * minimum: 67.8
   * maximum: 123.4
   * @return _double
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_DOUBLE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public Double getDouble() {
    return _double;
  }


  @JsonProperty(JSON_PROPERTY_DOUBLE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setDouble(@jakarta.annotation.Nullable Double _double) {
    this._double = _double;
  }

  public FormatTest decimal(@jakarta.annotation.Nullable BigDecimal decimal) {
    
    this.decimal = decimal;
    return this;
  }

  /**
   * Get decimal
   * @return decimal
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_DECIMAL)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public BigDecimal getDecimal() {
    return decimal;
  }


  @JsonProperty(JSON_PROPERTY_DECIMAL)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setDecimal(@jakarta.annotation.Nullable BigDecimal decimal) {
    this.decimal = decimal;
  }

  public FormatTest string(@jakarta.annotation.Nullable String string) {
    
    this.string = string;
    return this;
  }

  /**
   * Get string
   * @return string
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_STRING)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public String getString() {
    return string;
  }


  @JsonProperty(JSON_PROPERTY_STRING)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setString(@jakarta.annotation.Nullable String string) {
    this.string = string;
  }

  public FormatTest _byte(@jakarta.annotation.Nonnull byte[] _byte) {
    
    this._byte = _byte;
    return this;
  }

  /**
   * Get _byte
   * @return _byte
   */
  @jakarta.annotation.Nonnull
  @Schema(requiredMode = Schema.RequiredMode.REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_BYTE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public byte[] getByte() {
    return _byte;
  }


  @JsonProperty(JSON_PROPERTY_BYTE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setByte(@jakarta.annotation.Nonnull byte[] _byte) {
    this._byte = _byte;
  }

  public FormatTest binary(@jakarta.annotation.Nullable File binary) {
    
    this.binary = binary;
    return this;
  }

  /**
   * Get binary
   * @return binary
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_BINARY)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public File getBinary() {
    return binary;
  }


  @JsonProperty(JSON_PROPERTY_BINARY)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setBinary(@jakarta.annotation.Nullable File binary) {
    this.binary = binary;
  }

  public FormatTest date(@jakarta.annotation.Nonnull LocalDate date) {
    
    this.date = date;
    return this;
  }

  /**
   * Get date
   * @return date
   */
  @jakarta.annotation.Nonnull
  @Schema(requiredMode = Schema.RequiredMode.REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_DATE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public LocalDate getDate() {
    return date;
  }


  @JsonProperty(JSON_PROPERTY_DATE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDate(@jakarta.annotation.Nonnull LocalDate date) {
    this.date = date;
  }

  public FormatTest dateTime(@jakarta.annotation.Nullable OffsetDateTime dateTime) {
    
    this.dateTime = dateTime;
    return this;
  }

  /**
   * Get dateTime
   * @return dateTime
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_DATE_TIME)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public OffsetDateTime getDateTime() {
    return dateTime;
  }


  @JsonProperty(JSON_PROPERTY_DATE_TIME)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setDateTime(@jakarta.annotation.Nullable OffsetDateTime dateTime) {
    this.dateTime = dateTime;
  }

  public FormatTest duration(@jakarta.annotation.Nonnull String duration) {
    
    this.duration = duration;
    return this;
  }

  /**
   * Get duration
   * @return duration
   */
  @jakarta.annotation.Nonnull
  @Schema(requiredMode = Schema.RequiredMode.REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_DURATION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getDuration() {
    return duration;
  }


  @JsonProperty(JSON_PROPERTY_DURATION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDuration(@jakarta.annotation.Nonnull String duration) {
    this.duration = duration;
  }

  public FormatTest uuid(@jakarta.annotation.Nullable UUID uuid) {
    
    this.uuid = uuid;
    return this;
  }

  /**
   * Get uuid
   * @return uuid
   */
  @jakarta.annotation.Nullable
  @Schema(example = "72f98069-206d-4f12-9f12-3d1e525a8e84", requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_UUID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public UUID getUuid() {
    return uuid;
  }


  @JsonProperty(JSON_PROPERTY_UUID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setUuid(@jakarta.annotation.Nullable UUID uuid) {
    this.uuid = uuid;
  }

  public FormatTest password(@jakarta.annotation.Nonnull String password) {
    
    this.password = password;
    return this;
  }

  /**
   * Get password
   * @return password
   */
  @jakarta.annotation.Nonnull
  @Schema(requiredMode = Schema.RequiredMode.REQUIRED, description = "")
  @JsonProperty(JSON_PROPERTY_PASSWORD)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getPassword() {
    return password;
  }


  @JsonProperty(JSON_PROPERTY_PASSWORD)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setPassword(@jakarta.annotation.Nonnull String password) {
    this.password = password;
  }

  public FormatTest patternWithDigits(@jakarta.annotation.Nullable String patternWithDigits) {
    
    this.patternWithDigits = patternWithDigits;
    return this;
  }

  /**
   * A string that is a 10 digit number. Can have leading zeros.
   * @return patternWithDigits
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "A string that is a 10 digit number. Can have leading zeros.")
  @JsonProperty(JSON_PROPERTY_PATTERN_WITH_DIGITS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public String getPatternWithDigits() {
    return patternWithDigits;
  }


  @JsonProperty(JSON_PROPERTY_PATTERN_WITH_DIGITS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setPatternWithDigits(@jakarta.annotation.Nullable String patternWithDigits) {
    this.patternWithDigits = patternWithDigits;
  }

  public FormatTest patternWithDigitsAndDelimiter(@jakarta.annotation.Nullable String patternWithDigitsAndDelimiter) {
    
    this.patternWithDigitsAndDelimiter = patternWithDigitsAndDelimiter;
    return this;
  }

  /**
   * A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.
   * @return patternWithDigitsAndDelimiter
   */
  @jakarta.annotation.Nullable
  @Schema(requiredMode = Schema.RequiredMode.NOT_REQUIRED, description = "A string starting with 'image_' (case insensitive) and one to three digits following i.e. Image_01.")
  @JsonProperty(JSON_PROPERTY_PATTERN_WITH_DIGITS_AND_DELIMITER)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public String getPatternWithDigitsAndDelimiter() {
    return patternWithDigitsAndDelimiter;
  }


  @JsonProperty(JSON_PROPERTY_PATTERN_WITH_DIGITS_AND_DELIMITER)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setPatternWithDigitsAndDelimiter(@jakarta.annotation.Nullable String patternWithDigitsAndDelimiter) {
    this.patternWithDigitsAndDelimiter = patternWithDigitsAndDelimiter;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FormatTest formatTest = (FormatTest) o;
    return Objects.equals(this.integer, formatTest.integer) &&
        Objects.equals(this.int32, formatTest.int32) &&
        Objects.equals(this.int64, formatTest.int64) &&
        Objects.equals(this.number, formatTest.number) &&
        Objects.equals(this._float, formatTest._float) &&
        Objects.equals(this._double, formatTest._double) &&
        Objects.equals(this.decimal, formatTest.decimal) &&
        Objects.equals(this.string, formatTest.string) &&
        Arrays.equals(this._byte, formatTest._byte) &&
        Objects.equals(this.binary, formatTest.binary) &&
        Objects.equals(this.date, formatTest.date) &&
        Objects.equals(this.dateTime, formatTest.dateTime) &&
        Objects.equals(this.duration, formatTest.duration) &&
        Objects.equals(this.uuid, formatTest.uuid) &&
        Objects.equals(this.password, formatTest.password) &&
        Objects.equals(this.patternWithDigits, formatTest.patternWithDigits) &&
        Objects.equals(this.patternWithDigitsAndDelimiter, formatTest.patternWithDigitsAndDelimiter);
  }

  @Override
  public int hashCode() {
    return Objects.hash(integer, int32, int64, number, _float, _double, decimal, string, Arrays.hashCode(_byte), binary, date, dateTime, duration, uuid, password, patternWithDigits, patternWithDigitsAndDelimiter);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FormatTest {\n");
    sb.append("    integer: ").append(toIndentedString(integer)).append("\n");
    sb.append("    int32: ").append(toIndentedString(int32)).append("\n");
    sb.append("    int64: ").append(toIndentedString(int64)).append("\n");
    sb.append("    number: ").append(toIndentedString(number)).append("\n");
    sb.append("    _float: ").append(toIndentedString(_float)).append("\n");
    sb.append("    _double: ").append(toIndentedString(_double)).append("\n");
    sb.append("    decimal: ").append(toIndentedString(decimal)).append("\n");
    sb.append("    string: ").append(toIndentedString(string)).append("\n");
    sb.append("    _byte: ").append(toIndentedString(_byte)).append("\n");
    sb.append("    binary: ").append(toIndentedString(binary)).append("\n");
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    dateTime: ").append(toIndentedString(dateTime)).append("\n");
    sb.append("    duration: ").append(toIndentedString(duration)).append("\n");
    sb.append("    uuid: ").append(toIndentedString(uuid)).append("\n");
    sb.append("    password: ").append("*").append("\n");
    sb.append("    patternWithDigits: ").append(toIndentedString(patternWithDigits)).append("\n");
    sb.append("    patternWithDigitsAndDelimiter: ").append(toIndentedString(patternWithDigitsAndDelimiter)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

