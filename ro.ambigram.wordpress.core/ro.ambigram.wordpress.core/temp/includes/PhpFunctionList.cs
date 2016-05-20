using ro.ambigram.wordpress.core.common;
using System;
using System.Collections.Generic;

namespace ro.ambigram.wordpress.core
{
    public class WpFunctionList
    {
        /// <summary>
        ///       * HTTP request for URI to retrieve content.
 //*
 //* @since 1.5.1
 //*
 //* @see wp_safe_remote_get()
 //*
 //* @param string $uri URI/URL of web page to retrieve.
 //* @return false|string HTTP content.False on failure.
 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public Func<String,Object> wp_remote_open(String uri)
        {
            //           $parsed_url = @parse_url( $uri);

            //           if (!$parsed_url || !is_array( $parsed_url) )
            //	return false;

            //$options = array();
            //$options['timeout'] = 10;

            //$response = wp_safe_remote_get( $uri, $options);

            //           if (is_wp_error( $response))
            //               return false;

            //           return wp_remote_retrieve_body( $response);
            return null;
        }
        public Func<Uri, WpSiteRequestContext, Object> wp_safe_remote_get = (a, b) =>
        {
            return null;
        };

        /// <summary>
        /// a is a response from wp_safe_remote_get
        /// </summary>
        public Func<Object, Object> wp_remote_retrieve_body = (a) =>
         {
             return a;
         };
        /// <summary>
        /// setup wp query
        /// </summary>
        public Action<Object> wp = ((query_vars) =>
        {
    
          
            /**
             * Set up the WordPress query.
             *
             * @since 2.0.0
             *
             * @global WP       $wp_locale
             * @global WP_Query $wp_query
             * @global WP_Query $wp_the_query
             *
             * @param string|array $query_vars Default WP_Query arguments.
             */
            //function wp( $query_vars = '' ) {
              //  global $wp, $wp_query, $wp_the_query;
	//$wp->main( $query_vars);

      //          if (!isset($wp_the_query))
	//	$wp_the_query = $wp_query;
      //      }
        });

        /// <summary>
        /// get server protocol.
        /// definde in load.php
        /// </summary>
        public Func<String> wp_get_server_protocol = () =>
          {
              return "HTTP/1.0";
          };

        
    }
}