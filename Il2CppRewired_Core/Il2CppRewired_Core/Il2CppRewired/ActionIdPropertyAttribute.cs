using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000003 RID: 3
	public class ActionIdPropertyAttribute : PropertyAttribute
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0002C7CC File Offset: 0x0002A9CC
		// Note: this type is marked as 'beforefieldinit'.
		static ActionIdPropertyAttribute()
		{
			Il2CppClassPointerStore<ActionIdPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ActionIdPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionIdPropertyAttribute>.NativeClassPtr);
			ActionIdPropertyAttribute.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionIdPropertyAttribute>.NativeClassPtr, "HLmDmUQWoPLmPsyHTHuhoXXcGIu");
			ActionIdPropertyAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIdPropertyAttribute>.NativeClassPtr, 100663298);
			ActionIdPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIdPropertyAttribute>.NativeClassPtr, 100663299);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0002C838 File Offset: 0x0002AA38
		public unsafe Type Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionIdPropertyAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0002C878 File Offset: 0x0002AA78
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionIdPropertyAttribute(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionIdPropertyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionIdPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002097 File Offset: 0x00000297
		public ActionIdPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0002C8C4 File Offset: 0x0002AAC4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020A0 File Offset: 0x000002A0
		public unsafe Type HLmDmUQWoPLmPsyHTHuhoXXcGIu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionIdPropertyAttribute.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionIdPropertyAttribute.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
