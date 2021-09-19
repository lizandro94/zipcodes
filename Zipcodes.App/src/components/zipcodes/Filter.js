import React from 'react';
import { Select } from 'antd';

const Filter = ({ postalRecords, onChangeZipcode }) => {
    const { Option } = Select;

    const filterOptions = (input, option) =>
        option.children.toLowerCase().indexOf(input.toLowerCase()) >= 0

    return (
        <Select
            showSearch
            style={{ width: '100%' }}
            placeholder="Select a zipcode"
            optionFilterProp="children"
            onChange={onChangeZipcode}
            filterOption={filterOptions}
        >
            {postalRecords.map(record =>
                <Option key={record.key} value={record.key}>
                    {record.displayText}
                </Option>)}
        </Select>
    );
};

export default Filter;