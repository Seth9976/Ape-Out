using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000447 RID: 1095
	public sealed class GuidAttribute : Attribute
	{
		// Token: 0x060043C7 RID: 17351 RVA: 0x00139384 File Offset: 0x00137584
		// Note: this type is marked as 'beforefieldinit'.
		static GuidAttribute()
		{
			Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "GuidAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr);
			GuidAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr, "_val");
			GuidAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr, 100673176);
			GuidAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr, 100673177);
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x001393F0 File Offset: 0x001375F0
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuidAttribute(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x0013943C File Offset: 0x0013763C
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00019C71 File Offset: 0x00017E71
		public GuidAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x060043CB RID: 17355 RVA: 0x00139474 File Offset: 0x00137674
		// (set) Token: 0x060043CC RID: 17356 RVA: 0x00019C7A File Offset: 0x00017E7A
		public unsafe string _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuidAttribute.NativeFieldInfoPtr__val);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuidAttribute.NativeFieldInfoPtr__val), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400374F RID: 14159
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04003750 RID: 14160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003751 RID: 14161
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
