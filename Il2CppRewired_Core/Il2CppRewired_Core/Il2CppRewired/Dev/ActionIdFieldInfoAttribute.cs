using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Dev
{
	// Token: 0x02000002 RID: 2
	public class ActionIdFieldInfoAttribute : Attribute
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0002C6D4 File Offset: 0x0002A8D4
		// Note: this type is marked as 'beforefieldinit'.
		static ActionIdFieldInfoAttribute()
		{
			Il2CppClassPointerStore<ActionIdFieldInfoAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Dev", "ActionIdFieldInfoAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionIdFieldInfoAttribute>.NativeClassPtr);
			ActionIdFieldInfoAttribute.NativeFieldInfoPtr_categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionIdFieldInfoAttribute>.NativeClassPtr, "categoryName");
			ActionIdFieldInfoAttribute.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionIdFieldInfoAttribute>.NativeClassPtr, "friendlyName");
			ActionIdFieldInfoAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIdFieldInfoAttribute>.NativeClassPtr, 100663297);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0002C740 File Offset: 0x0002A940
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionIdFieldInfoAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionIdFieldInfoAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionIdFieldInfoAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public ActionIdFieldInfoAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0002C77C File Offset: 0x0002A97C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe string categoryName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionIdFieldInfoAttribute.NativeFieldInfoPtr_categoryName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionIdFieldInfoAttribute.NativeFieldInfoPtr_categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0002C7A4 File Offset: 0x0002A9A4
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002078 File Offset: 0x00000278
		public unsafe string friendlyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionIdFieldInfoAttribute.NativeFieldInfoPtr_friendlyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionIdFieldInfoAttribute.NativeFieldInfoPtr_friendlyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_categoryName;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
