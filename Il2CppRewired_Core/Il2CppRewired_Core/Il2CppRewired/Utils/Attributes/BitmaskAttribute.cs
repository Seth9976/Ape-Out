using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Attributes
{
	// Token: 0x02000004 RID: 4
	public class BitmaskAttribute : PropertyAttribute
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
		// Note: this type is marked as 'beforefieldinit'.
		static BitmaskAttribute()
		{
			Il2CppClassPointerStore<BitmaskAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Attributes", "BitmaskAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitmaskAttribute>.NativeClassPtr);
			BitmaskAttribute.NativeFieldInfoPtr_propType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmaskAttribute>.NativeClassPtr, "propType");
			BitmaskAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmaskAttribute>.NativeClassPtr, 100663300);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0002C94C File Offset: 0x0002AB4C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitmaskAttribute(Type aType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitmaskAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmaskAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020BF File Offset: 0x000002BF
		public BitmaskAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0002C998 File Offset: 0x0002AB98
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020C8 File Offset: 0x000002C8
		public unsafe Type propType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmaskAttribute.NativeFieldInfoPtr_propType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmaskAttribute.NativeFieldInfoPtr_propType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_propType;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
