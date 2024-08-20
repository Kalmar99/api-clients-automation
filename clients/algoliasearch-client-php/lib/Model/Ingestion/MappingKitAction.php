<?php

// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

namespace Algolia\AlgoliaSearch\Model\Ingestion;

use Algolia\AlgoliaSearch\Model\AbstractModel;

/**
 * MappingKitAction Class Doc Comment.
 *
 * @category Class
 *
 * @description Describes how a destination object should be resolved by means of applying a set of directives.
 */
class MappingKitAction extends AbstractModel implements ModelInterface, \ArrayAccess, \JsonSerializable
{
    /**
     * Array of property to type mappings. Used for (de)serialization.
     *
     * @var string[]
     */
    protected static $modelTypes = [
        'id' => 'string',
        'enabled' => 'bool',
        'trigger' => 'string',
        'fieldDirectives' => '\Algolia\AlgoliaSearch\Model\Ingestion\MappingFieldDirective[]',
    ];

    /**
     * Array of property to format mappings. Used for (de)serialization.
     *
     * @var string[]
     */
    protected static $modelFormats = [
        'id' => null,
        'enabled' => null,
        'trigger' => null,
        'fieldDirectives' => null,
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name.
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'id' => 'id',
        'enabled' => 'enabled',
        'trigger' => 'trigger',
        'fieldDirectives' => 'fieldDirectives',
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses).
     *
     * @var string[]
     */
    protected static $setters = [
        'id' => 'setId',
        'enabled' => 'setEnabled',
        'trigger' => 'setTrigger',
        'fieldDirectives' => 'setFieldDirectives',
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests).
     *
     * @var string[]
     */
    protected static $getters = [
        'id' => 'getId',
        'enabled' => 'getEnabled',
        'trigger' => 'getTrigger',
        'fieldDirectives' => 'getFieldDirectives',
    ];

    /**
     * Associative array for storing property values.
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor.
     *
     * @param mixed[] $data Associated array of property values
     */
    public function __construct(?array $data = null)
    {
        if (isset($data['id'])) {
            $this->container['id'] = $data['id'];
        }
        if (isset($data['enabled'])) {
            $this->container['enabled'] = $data['enabled'];
        }
        if (isset($data['trigger'])) {
            $this->container['trigger'] = $data['trigger'];
        }
        if (isset($data['fieldDirectives'])) {
            $this->container['fieldDirectives'] = $data['fieldDirectives'];
        }
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name.
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of property to type mappings. Used for (de)serialization.
     *
     * @return array
     */
    public static function modelTypes()
    {
        return self::$modelTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization.
     *
     * @return array
     */
    public static function modelFormats()
    {
        return self::$modelFormats;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses).
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests).
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if (!isset($this->container['enabled']) || null === $this->container['enabled']) {
            $invalidProperties[] = "'enabled' can't be null";
        }
        if (!isset($this->container['trigger']) || null === $this->container['trigger']) {
            $invalidProperties[] = "'trigger' can't be null";
        }
        if (!isset($this->container['fieldDirectives']) || null === $this->container['fieldDirectives']) {
            $invalidProperties[] = "'fieldDirectives' can't be null";
        }

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed.
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return 0 === count($this->listInvalidProperties());
    }

    /**
     * Gets id.
     *
     * @return null|string
     */
    public function getId()
    {
        return $this->container['id'] ?? null;
    }

    /**
     * Sets id.
     *
     * @param null|string $id ID to uniquely identify this action
     *
     * @return self
     */
    public function setId($id)
    {
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets enabled.
     *
     * @return bool
     */
    public function getEnabled()
    {
        return $this->container['enabled'] ?? null;
    }

    /**
     * Sets enabled.
     *
     * @param bool $enabled whether this action has any effect
     *
     * @return self
     */
    public function setEnabled($enabled)
    {
        $this->container['enabled'] = $enabled;

        return $this;
    }

    /**
     * Gets trigger.
     *
     * @return string
     */
    public function getTrigger()
    {
        return $this->container['trigger'] ?? null;
    }

    /**
     * Sets trigger.
     *
     * @param string $trigger Condition which must be satisfied to apply the action. If this evaluates to false, the action is not applied, and the process attempts to apply the next action, if any.
     *
     * @return self
     */
    public function setTrigger($trigger)
    {
        $this->container['trigger'] = $trigger;

        return $this;
    }

    /**
     * Gets fieldDirectives.
     *
     * @return \Algolia\AlgoliaSearch\Model\Ingestion\MappingFieldDirective[]
     */
    public function getFieldDirectives()
    {
        return $this->container['fieldDirectives'] ?? null;
    }

    /**
     * Sets fieldDirectives.
     *
     * @param \Algolia\AlgoliaSearch\Model\Ingestion\MappingFieldDirective[] $fieldDirectives fieldDirectives
     *
     * @return self
     */
    public function setFieldDirectives($fieldDirectives)
    {
        $this->container['fieldDirectives'] = $fieldDirectives;

        return $this;
    }

    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param int $offset Offset
     */
    public function offsetExists($offset): bool
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param int $offset Offset
     *
     * @return null|mixed
     */
    public function offsetGet($offset): mixed
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param null|int $offset Offset
     * @param mixed    $value  Value to be set
     */
    public function offsetSet($offset, $value): void
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param int $offset Offset
     */
    public function offsetUnset($offset): void
    {
        unset($this->container[$offset]);
    }
}
