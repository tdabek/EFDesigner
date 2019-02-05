//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sandbox_EFCore
{
   public partial class User
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected User()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="role"></param>
      public User(Sandbox_EFCore.Role role)
      {
         if (role == null) throw new ArgumentNullException(nameof(role));
         Role = role;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="role"></param>
      public static User Create(Sandbox_EFCore.Role role)
      {
         return new User(role);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      protected long _Id;
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before setting.
      /// </summary>
      partial void SetId(long oldValue, ref long newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before returning.
      /// </summary>
      partial void GetId(ref long result);

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public long Id
      {
         get
         {
            long value = _Id;
            GetId(ref value);
            return (_Id = value);
         }
         set
         {
            long oldValue = _Id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _Id = value;
            }
                Microsoft.EntityFrameworkCore.ChangeTracking.ObservableHashSet<string> s;
         }
      }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      protected Sandbox_EFCore.Role _Role;
      partial void SetRole(Sandbox_EFCore.Role oldValue, ref Sandbox_EFCore.Role newValue);
      partial void GetRole(ref Sandbox_EFCore.Role result);

      /// <summary>
      /// Required{br/}
      /// Role
      /// </summary>
      public virtual Sandbox_EFCore.Role Role { get; set; }

   }
}

