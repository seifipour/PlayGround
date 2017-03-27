using CodeCrack.src.linkedlist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCrack.LinkedList.test
{
    [TestClass]
    public class SumOfTwoLinkedListWhenOnesIsRightTest
    {
        [TestMethod]
        public void return_sum()
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

            var result = SumOFLinkedListWhenOneIsRight
                        .sum_of_two_linked_list_when_ones_in_right_return_recursion(
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
        public void return_sum_with_carry_over()
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
            expected_result.append(1);
            expected_result.append(3);
            expected_result.append(8);
            expected_result.append(3);

            //act

            var result = SumOFLinkedListWhenOneIsRight
                        .sum_of_two_linked_list_when_ones_in_right_return_recursion(
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
        public void return_sum_with_carry_over_with_different_length()
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
            expected_result.append(4);
            expected_result.append(8);
            expected_result.append(3);

            //act

            var result = SumOFLinkedListWhenOneIsRight
                        .sum_of_two_linked_list_when_ones_in_right_return_recursion(
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
        public void return_sum_with_carry_over_with_different_length_2()
        {
            //arrange

            var first = new LinkedList<int>();
            first.append(3);
            first.append(8);
            first.append(7);
            first.append(1);


            var second = new LinkedList<int>();
            second.append(9);
            second.append(6);

            var expected_result = new LinkedList<int>();
            expected_result.append(3);
            expected_result.append(9);
            expected_result.append(6);
            expected_result.append(7);

            //act

            var result = SumOFLinkedListWhenOneIsRight
                        .sum_of_two_linked_list_when_ones_in_right_return_recursion(
                             first: first,
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
        ///  forward recursion
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

            var result = SumOFLinkedListWhenOneIsRight
                        .sum_of_two_linked_list_when_ones_in_right_forward_recursion(
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
            expected_result.append(1);
            expected_result.append(3);
            expected_result.append(8);
            expected_result.append(3);

            //act

            var result = SumOFLinkedListWhenOneIsRight
                        .sum_of_two_linked_list_when_ones_in_right_forward_recursion(
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
            expected_result.append(4);
            expected_result.append(8);
            expected_result.append(3);

            //act

            var result = SumOFLinkedListWhenOneIsRight
                        .sum_of_two_linked_list_when_ones_in_right_forward_recursion(
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
