using ro.ambigram.wordpress.core.common;
using System;
using System.Collections.Generic;

namespace ro.ambigram.wordpress.core
{
    public class WpFunctions
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
        public Func<String, Object> wp_remote_open(String uri)
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

        public Action wp_unregister_GLOBALS = () =>
        {

            //               if (!ini_get('register_globals'))
            //                   return;

            //               if (isset( $_REQUEST['GLOBALS']))
            //                   die('GLOBALS overwrite attempt detected');

            //// Variables that shouldn't be unset
            //$no_unset = array('GLOBALS', '_GET', '_POST', '_COOKIE', '_REQUEST', '_SERVER', '_ENV', '_FILES', 'table_prefix');

            //$input = array_merge( $_GET, $_POST, $_COOKIE, $_SERVER, $_ENV, $_FILES, isset( $_SESSION) && is_array( $_SESSION) ? $_SESSION: array());
            //               foreach ( $input as $k => $v )
            //	if (!in_array( $k, $no_unset) && isset( $GLOBALS[$k]))
            //               {
            //                   unset( $GLOBALS[$k]);
            //               }
            //           }
        };

        public Action wp_fix_server_vars = () => { };

        public Action wp_check_php_mysql_version => () =>
        {
            WpPrerequisiteManager.check_db_access();
        };

        public Action wp_favicon_request = () =>
        {
            throw new NotImplementedException("wp_favicon_request");
        };

        public Action wp_maintenance = () =>
        {
            throw new NotImplementedException("wp_maintenance");
        };
        public Action wp_translation_early = () =>
        {
            throw new NotImplementedException();
        };


        public Func<bool> timer_start = () =>
        {
            return true;
        };
        public Func<int?, int?, Object> timer_stop = (a, b) =>
          {
              return new { };
          };


        public Action wp_debug_mode = () =>
        {
            throw new NotImplementedException();
        };
        public Action wp_set_lang_dir = () =>
        {
            throw new NotImplementedException();
        };

        public Func<WpDb> require_wp_db = () =>
        {
            return WpDb.Current;
        };

        public Action wp_set_wpdb_vars = () =>
        {
            throw new NotImplementedException();
        };

        private static Action TempNotImplemented1 = () =>
        {
            throw new NotImplementedException();
        };
        private static Action<int> TempNotImplemented2 = (a) =>
        {
            throw new NotImplementedException();
        };
        public Action wp_start_object_cache = TempNotImplemented1;

        public Action<int> wp_cache_switch_to_blog = TempNotImplemented2;

        public Action<bool> wp_using_ext_object_cache = TempNotImplemented3;

        private static void TempNotImplemented3(bool obj)
        {
            throw new NotImplementedException();
        }



    }
}