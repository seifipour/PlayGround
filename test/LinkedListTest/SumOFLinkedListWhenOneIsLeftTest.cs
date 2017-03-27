using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.test.linkedlisttest
{
    [TestClass]
    public class SumOFLinkedListWhenOneIsLeftTest
    {
        [TestMethod]
        public void return_sum_with_return_recursion()
        {
            //arrange

            var fisrt = new LinkedList<int>();
            fisrt.append(1);
            fisrt.append(1);
            fisrt.append(0);

            var second = new LinkedList<int>();
            second.append(2);
            second.append(2);
            second.append(0);

            var expected_result = new LinkedList<int>();
            expected_result.append(3);
            expected_result.append(3);
            expected_result.append(0);

            //act

            var result = SumOFLinkedListWhenOneIsLeft
                        .sum_of_two_linked_list_when_ones_is_left_with_return_recursion(
                             first: fisrt,
                             second: second
                         );

            //assert
            Assert.IsNotNull(result);
            while (result.head != null && expected_result.head != null)
            {

                Assert.AreEqual(result.head.data, expected_result.head.data);

                result.head = result.head.next;
                expected_result.head = expected_result.head.next;

            }

        }

        [TestMethod]
        public void return_sum_with_carry_over_with_return_recursion()
        {
            //arrange

            var fisrt = new LinkedList<int>();
            fisrt.append(3);
            fisrt.append(8);
            fisrt.append(7);

            var second = new LinkedList<int>();
            second.append(9);
            second.append(9);
            second.append(6);

            var expected_result = new LinkedList<int>();
            expected_result.append(2);
            expected_result.append(8);
            expected_result.append(4);
            expected_result.append(1);

            //act

            var result = SumOFLinkedListWhenOneIsLeft
                        .sum_of_two_linked_list_when_ones_is_left_with_return_recursion(
                             first: fisrt,
                             second: second
                         );

            //assert
            Assert.IsNotNull(result);
            while (result.head != null && expected_result.head != null)
            {

                Assert.AreEqual(result.head.data, expected_result.head.data);

                result.head = result.head.next;
                expected_result.head = expected_result.head.next;

            }

        }

        [TestMethod]
        public void return_sum_with_carry_over_with_different_length_with_return_recursion()
        {
            //arrange

            var fisrt = new LinkedList<int>();
            fisrt.append(3);
            fisrt.append(8);
            fisrt.append(7);

            var second = new LinkedList<int>();
            second.append(9);
            second.append(6);

            var expected_result = new LinkedList<int>();
            expected_result.append(2);
            expected_result.append(5);
            expected_result.append(8);

            //act

            var result = SumOFLinkedListWhenOneIsLeft
                        .sum_of_two_linked_list_when_ones_is_left_with_return_recursion(
                             first: fisrt,
                             second: second
                         );

            //assert
            Assert.IsNotNull(result);
            while (result.head != null && expected_result.head != null)
            {

                Assert.AreEqual(result.head.data, expected_result.head.data);

                result.head = result.head.next;
                expected_result.head = expected_result.head.next;

            }

        }


        /// <summary>
        /// forward recursion 
        /// </summary>
        [TestMethod]
        public void return_sum_with_forward_recursion()
        {
            //arrange

            var fisrt = new LinkedList<int>();
            fisrt.append(1);
            fisrt.append(1);
            fisrt.append(0);

            var second = new LinkedList<int>();
            second.append(2);
            second.append(2);
            second.append(0);

            var expected_result = new LinkedList<int>();
            expected_result.append(3);
            expected_result.append(3);
            expected_result.append(0);

            //act

            var result = SumOFLinkedListWhenOneIsLeft
                        .sum_of_two_linked_list_when_ones_is_left_with_forward_recursion(
                             first: fisrt,
                             second: second
                         );

            //assert
            Assert.IsNotNull(result);
            while (result.head != null && expected_result.head != null)
            {

                Assert.AreEqual(result.head.data, expected_result.head.data);

                result.head = result.head.next;
                expected_result.head = expected_result.head.next;

            }

        }

        [TestMethod]
        public void return_sum_with_carry_over_with_forward_recursion()
        {
            //arrange

            var fisrt = new LinkedList<int>();
            fisrt.append(3);
            fisrt.append(8);
            fisrt.append(7);

            var second = new LinkedList<int>();
            second.append(9);
            second.append(9);
            second.append(6);

            var expected_result = new LinkedList<int>();
            expected_result.append(2);
            expected_result.append(8);
            expected_result.append(4);
            expected_result.append(1);

            //act

            var result = SumOFLinkedListWhenOneIsLeft
                        .sum_of_two_linked_list_when_ones_is_left_with_forward_recursion(
                             first: fisrt,
                             second: second
                         );

            //assert
            Assert.IsNotNull(result);
            while (result.head != null && expected_result.head != null)
            {

                Assert.AreEqual(result.head.data, expected_result.head.data);

                result.head = result.head.next;
                expected_result.head = expected_result.head.next;

            }

        }

        [TestMethod]
        public void return_sum_with_carry_over_with_different_length_with_forward_recursion()
        {
            //arrange

            var fisrt = new LinkedList<int>();
            fisrt.append(3);
            fisrt.append(8);
            fisrt.append(7);

            var second = new LinkedList<int>();
            second.append(9);
            second.append(6);

            var expected_result = new LinkedList<int>();
            expected_result.append(2);
            expected_result.append(5);
            expected_result.append(8);

            //act

            var result = SumOFLinkedListWhenOneIsLeft
                        .sum_of_two_linked_list_when_ones_is_left_with_forward_recursion(
                             first: fisrt,
                             second: second
                         );

            //assert
            Assert.IsNotNull(result);
            while (result.head != null && expected_result.head != null)
            {

                Assert.AreEqual(result.head.data, expected_result.head.data);

                result.head = result.head.next;
                expected_result.head = expected_result.head.next;

            }

        }
    }
}
