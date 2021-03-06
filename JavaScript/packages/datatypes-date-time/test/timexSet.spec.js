// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

const chai = require('chai');

const { TimexProperty, TimexSet } = require('../index.js');

const assert = chai.assert;
const expect = chai.expect;
chai.should();

describe('No Network', () => {
    describe('Datatypes', () => {
        describe('Timex', () => {
            describe('Set', () => {
                it('every 2 days', () => {
                    const timexSet = new TimexSet('P2D');
                    timexSet.should.have.property('timex');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('duration');
                    timex.should.not.have.property('year');
                    timex.should.not.have.property('month');
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.not.have.property('dayOfWeek');
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.not.have.property('season');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.not.have.property('partOfDay');
                    timex.should.not.have.property('years');
                    timex.should.not.have.property('months');
                    timex.should.not.have.property('weeks');
                    timex.should.have.property('days', 2);
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
                it('each week', () => {
                    const timexSet = new TimexSet('P1W');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('duration');
                    timex.should.not.have.property('year');
                    timex.should.not.have.property('month');
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.not.have.property('dayOfWeek');
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.not.have.property('season');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.not.have.property('partOfDay');
                    timex.should.not.have.property('years');
                    timex.should.not.have.property('months');
                    timex.should.have.property('weeks', 1);
                    timex.should.not.have.property('days');
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
                it('every october', () => {
                    const timexSet = new TimexSet('XXXX-10');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('daterange');
                    timex.should.not.have.property('year');
                    timex.should.have.property('month', 10);
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.not.have.property('dayOfWeek');
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.not.have.property('season');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.not.have.property('partOfDay');
                    timex.should.not.have.property('years');
                    timex.should.not.have.property('months');
                    timex.should.not.have.property('weeks');
                    timex.should.not.have.property('days');
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
                it('every sunday', () => {
                    const timexSet = new TimexSet('XXXX-WXX-7');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('date');
                    timex.should.not.have.property('year');
                    timex.should.not.have.property('month');
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.have.property('dayOfWeek', 7);
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.not.have.property('season');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.not.have.property('partOfDay');
                    timex.should.not.have.property('years');
                    timex.should.not.have.property('months');
                    timex.should.not.have.property('weeks');
                    timex.should.not.have.property('days');
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
                it('every day', () => {
                    const timexSet = new TimexSet('P1D');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('duration');
                    timex.should.not.have.property('year');
                    timex.should.not.have.property('month');
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.not.have.property('dayOfWeek');
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.not.have.property('season');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.not.have.property('partOfDay');
                    timex.should.not.have.property('years');
                    timex.should.not.have.property('months');
                    timex.should.not.have.property('weeks');
                    timex.should.have.property('days', 1);
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
                it('every year', () => {
                    const timexSet = new TimexSet('P1Y');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('duration');
                    timex.should.not.have.property('year');
                    timex.should.not.have.property('month');
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.not.have.property('dayOfWeek');
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.not.have.property('season');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.not.have.property('partOfDay');
                    timex.should.have.property('years', 1);
                    timex.should.not.have.property('months');
                    timex.should.not.have.property('weeks');
                    timex.should.not.have.property('days');
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
                it('every spring', () => {
                    const timexSet = new TimexSet('SP');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('daterange');
                    timex.should.not.have.property('year');
                    timex.should.not.have.property('month');
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.not.have.property('dayOfWeek');
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.have.property('season', 'SP');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.not.have.property('partOfDay');
                    timex.should.not.have.property('years');
                    timex.should.not.have.property('months');
                    timex.should.not.have.property('weeks');
                    timex.should.not.have.property('days');
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
                it('each winter', () => {
                    const timexSet = new TimexSet('WI');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('daterange');
                    timex.should.not.have.property('year');
                    timex.should.not.have.property('month');
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.not.have.property('dayOfWeek');
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.have.property('season', 'WI');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.not.have.property('partOfDay');
                    timex.should.not.have.property('years');
                    timex.should.not.have.property('months');
                    timex.should.not.have.property('weeks');
                    timex.should.not.have.property('days');
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
                it('every evening', () => {
                    const timexSet = new TimexSet('TEV');
                    const timex = timexSet.timex;
                    timex.should.have.property('types').that.is.a('Set').that.has.keys('timerange');
                    timex.should.not.have.property('year');
                    timex.should.not.have.property('month');
                    timex.should.not.have.property('dayOfMonth');
                    timex.should.not.have.property('dayOfWeek');
                    timex.should.not.have.property('weekOfYear');
                    timex.should.not.have.property('weekOfMonth');
                    timex.should.not.have.property('season');
                    timex.should.not.have.property('hour');
                    timex.should.not.have.property('minute');
                    timex.should.not.have.property('second');
                    timex.should.not.have.property('weekend');
                    timex.should.have.property('partOfDay', 'EV');
                    timex.should.not.have.property('years');
                    timex.should.not.have.property('months');
                    timex.should.not.have.property('weeks');
                    timex.should.not.have.property('days');
                    timex.should.not.have.property('hours');
                    timex.should.not.have.property('minutes');
                    timex.should.not.have.property('seconds');
                });
            });
        });
    });
});
