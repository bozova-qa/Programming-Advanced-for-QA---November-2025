import {mathEnforcer} from '../mathEnforcer.js'
import { assert } from 'chai'

describe('test_mathEnforcer', () => {
    describe('addFive', () => {
        it('should return undefined if parameter is not a number', () => {
            assert.equal(mathEnforcer.addFive('5'), undefined);
            assert.equal(mathEnforcer.addFive([]), undefined);
            assert.equal(mathEnforcer.addFive({}), undefined);
            assert.equal(mathEnforcer.addFive(null), undefined);
            assert.equal(mathEnforcer.addFive(undefined), undefined);
        }),

        it('should add five if parameter is a number', () => {
            assert.equal(mathEnforcer.addFive(5), 10);
            assert.equal(mathEnforcer.addFive(-3), 2);
            assert.equal(mathEnforcer.addFive(7.5), 12.5, 0.01);

        })
    });

    describe('subtractTen', () => {
        it('should return undefined if parameter is not a number', () => {
            assert.equal(mathEnforcer.subtractTen('5'), undefined);
            assert.equal(mathEnforcer.subtractTen([]), undefined);
            assert.equal(mathEnforcer.subtractTen({}), undefined);
            assert.equal(mathEnforcer.subtractTen(null), undefined);
            assert.equal(mathEnforcer.subtractTen(undefined), undefined);
        }),

        it('should subtract ten if parameter is a number', () => {
            assert.equal(mathEnforcer.subtractTen(15), 5);
            assert.equal(mathEnforcer.subtractTen(-3), -13);
            assert.equal(mathEnforcer.subtractTen(7.5),-2.5, 0.01);
        })
    });

    describe('sum', () => {
        it('should return undefined if first parameter is not a number', () => {
            assert.equal(mathEnforcer.sum('5', 5), undefined)
            assert.equal(mathEnforcer.sum([], 5), undefined)
            assert.equal(mathEnforcer.sum('five', 5), undefined)
            assert.equal(mathEnforcer.sum(null, 5), undefined)
            assert.equal(mathEnforcer.sum({}, 5), undefined)
        }),

        it('should return undefined if second parameter is not a number', () => {
            assert.equal(mathEnforcer.sum(3, '5'), undefined)
            assert.equal(mathEnforcer.sum(3, []), undefined)
            assert.equal(mathEnforcer.sum(3, 'five'), undefined)
            assert.equal(mathEnforcer.sum(3, null), undefined)
            assert.equal(mathEnforcer.sum(3, {}), undefined)
        }),

        it('should sum correctly if both parameters are valid', () => {
            assert.equal(mathEnforcer.sum(5, 12), 17)
            assert.equal(mathEnforcer.sum(-5, -10), -15)
            assert.closeTo(mathEnforcer.sum(2.5, 10.3), 12.8, 0.01)
        })
    });
})