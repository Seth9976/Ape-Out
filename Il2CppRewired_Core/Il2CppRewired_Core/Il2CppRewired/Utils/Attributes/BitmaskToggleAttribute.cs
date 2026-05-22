using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Attributes
{
	// Token: 0x02000005 RID: 5
	public class BitmaskToggleAttribute : PropertyAttribute
	{
		// Token: 0x06000013 RID: 19 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
		// Note: this type is marked as 'beforefieldinit'.
		static BitmaskToggleAttribute()
		{
			Il2CppClassPointerStore<BitmaskToggleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Attributes", "BitmaskToggleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitmaskToggleAttribute>.NativeClassPtr);
			BitmaskToggleAttribute.NativeFieldInfoPtr_propType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmaskToggleAttribute>.NativeClassPtr, "propType");
			BitmaskToggleAttribute.NativeFieldInfoPtr_showNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmaskToggleAttribute>.NativeClassPtr, "showNone");
			BitmaskToggleAttribute.NativeFieldInfoPtr_showAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmaskToggleAttribute>.NativeClassPtr, "showAll");
			BitmaskToggleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmaskToggleAttribute>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0002CA48 File Offset: 0x0002AC48
		[CallerCount(0)]
		public unsafe BitmaskToggleAttribute(Type aType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitmaskToggleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitmaskToggleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020E7 File Offset: 0x000002E7
		public BitmaskToggleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0002CA94 File Offset: 0x0002AC94
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe Type propType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmaskToggleAttribute.NativeFieldInfoPtr_propType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmaskToggleAttribute.NativeFieldInfoPtr_propType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0002CAC4 File Offset: 0x0002ACC4
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe bool showNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmaskToggleAttribute.NativeFieldInfoPtr_showNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmaskToggleAttribute.NativeFieldInfoPtr_showNone)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0002CAEC File Offset: 0x0002ACEC
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000212A File Offset: 0x0000032A
		public unsafe bool showAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmaskToggleAttribute.NativeFieldInfoPtr_showAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitmaskToggleAttribute.NativeFieldInfoPtr_showAll)) = value;
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_propType;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_showNone;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_showAll;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
