import React from 'react';
import { Descriptions, Statistic, Empty } from 'antd';

const ZipcodeDetails = ({ selectedRecord }) => {
    const { Item } = Descriptions;

    return (
        selectedRecord.key
            ?
            <Descriptions title="">
                <Item label=""><Statistic groupSeparator="" title="Zipcode" value={selectedRecord?.zipcode ?? '-'} /></Item>
                <Item label=""><Statistic title="Department" value={selectedRecord.department ?? '-'} /></Item>
                <Item label=""><Statistic title="Municipality" value={selectedRecord.municipality ?? '-'} /></Item>
                <Item label=""><Statistic title="Neighborhood" value={selectedRecord?.neighbourhood ?? '-'} /></Item>
            </Descriptions>
            : <Empty description="Please select a zipcode" />
    );
};

export default ZipcodeDetails;