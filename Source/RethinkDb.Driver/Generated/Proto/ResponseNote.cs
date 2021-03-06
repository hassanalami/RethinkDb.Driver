


//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

namespace RethinkDb.Driver.Proto {
    public enum ResponseNote {
        SEQUENCE_FEED = 1,
        ATOM_FEED = 2,
        ORDER_BY_LIMIT_FEED = 3,
        UNIONED_FEED = 4,
        INCLUDES_STATES = 5,
    }

    
       public static class ExtensionsForResponseNote {
            public static bool IsFeed(this ResponseNote note){
                 switch( note ){
                        case ResponseNote.SEQUENCE_FEED:
                            return true;
                        case ResponseNote.ATOM_FEED:
                            return true;
                        case ResponseNote.ORDER_BY_LIMIT_FEED:
                            return true;
                        case ResponseNote.UNIONED_FEED:
                            return true;
                    default:
                        return false;
                 }
            }
      }


}
