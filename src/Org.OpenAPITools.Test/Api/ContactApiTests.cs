/*
 * Combined API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing ContactApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ContactApiTests : IDisposable
    {
        private ContactApi instance;

        public ContactApiTests()
        {
            instance = new ContactApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContactApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ContactApi
            //Assert.IsType<ContactApi>(instance);
        }

        /// <summary>
        /// Test ContactGet
        /// </summary>
        [Fact]
        public void ContactGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ContactGet();
            //Assert.IsType<List<Contact>>(response);
        }

        /// <summary>
        /// Test ContactIdDelete
        /// </summary>
        [Fact]
        public void ContactIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ContactIdDelete(id);
            //Assert.IsType<List<Contact>>(response);
        }

        /// <summary>
        /// Test ContactIdGet
        /// </summary>
        [Fact]
        public void ContactIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ContactIdGet(id);
            //Assert.IsType<Contact>(response);
        }

        /// <summary>
        /// Test ContactIdPut
        /// </summary>
        [Fact]
        public void ContactIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //Contact? contact = null;
            //var response = instance.ContactIdPut(id, contact);
            //Assert.IsType<List<Contact>>(response);
        }

        /// <summary>
        /// Test ContactPost
        /// </summary>
        [Fact]
        public void ContactPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Contact? contact = null;
            //var response = instance.ContactPost(contact);
            //Assert.IsType<List<Contact>>(response);
        }
    }
}