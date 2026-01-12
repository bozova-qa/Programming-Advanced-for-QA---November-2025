import {sum} from '../sumOfnumbers.js';
import {expect, assert} from 'chai'

describe('Test function sum', () => {
    it ('should return correct sum if an array with numbers is passed', () => {
        // Arrange
        let array = [1, 2, 3, 4]
        let expected = 10;

        // Act
        let result = sum(array);

        // Assert
        expect(result).to.equal(expected);
    }),

    it ('should return same number if the array has one number', () => {
        // Arrange
        let array = [4];
        let expected = 4;

        // Act
        let result = sum(array)

        // Assert
        expect(result).to.equal(expected);
    }),

    it('should return zero if the array is empty', () => {
        // Arrange
        let array = [];
        let expected = 0;

        // Act
        let result = sum(array);

        // Assert
        expect(result).to.equal(expected);
        assert.equal(result, expected);
    })
});

//за да стартираме, 
// 1)отиваме в package json, пишем type: module - означава да приема всички JS файлове за модули
//2) срещу test пишем mocha
//3) пишем npm test в терминал; името на папката с тестове трябва да е test
//4) npx mocha test/sumOfNumbers.test.js - ако искаме само определен тест да пуснем