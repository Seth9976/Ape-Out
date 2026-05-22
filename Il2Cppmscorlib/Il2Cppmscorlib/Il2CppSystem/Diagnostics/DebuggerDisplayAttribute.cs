using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BD RID: 1213
	public sealed class DebuggerDisplayAttribute : Attribute
	{
		// Token: 0x060048CB RID: 18635 RVA: 0x001518C0 File Offset: 0x0014FAC0
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerDisplayAttribute()
		{
			Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerDisplayAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr);
			DebuggerDisplayAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "name");
			DebuggerDisplayAttribute.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "value");
			DebuggerDisplayAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "type");
			DebuggerDisplayAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, 100674206);
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00151940 File Offset: 0x0014FB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233214, XrefRangeEnd = 233219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerDisplayAttribute(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerDisplayAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x0001B2F2 File Offset: 0x000194F2
		public DebuggerDisplayAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x0015198C File Offset: 0x0014FB8C
		// (set) Token: 0x060048CF RID: 18639 RVA: 0x0001B2FB File Offset: 0x000194FB
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x001519B4 File Offset: 0x0014FBB4
		// (set) Token: 0x060048D1 RID: 18641 RVA: 0x0001B31A File Offset: 0x0001951A
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x001519DC File Offset: 0x0014FBDC
		// (set) Token: 0x060048D3 RID: 18643 RVA: 0x0001B339 File Offset: 0x00019539
		public unsafe string type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B06 RID: 15110
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003B07 RID: 15111
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04003B08 RID: 15112
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04003B09 RID: 15113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
