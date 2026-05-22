using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000190 RID: 400
	public sealed class AssemblyTrademarkAttribute : Attribute
	{
		// Token: 0x06001BB9 RID: 7097 RVA: 0x000A1A80 File Offset: 0x0009FC80
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyTrademarkAttribute()
		{
			Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyTrademarkAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr);
			AssemblyTrademarkAttribute.NativeFieldInfoPtr_m_trademark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr, "m_trademark");
			AssemblyTrademarkAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr, 100668021);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x000A1AD8 File Offset: 0x0009FCD8
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyTrademarkAttribute(string trademark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(trademark);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyTrademarkAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00009681 File Offset: 0x00007881
		public AssemblyTrademarkAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x000A1B24 File Offset: 0x0009FD24
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0000968A File Offset: 0x0000788A
		public unsafe string m_trademark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTrademarkAttribute.NativeFieldInfoPtr_m_trademark);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTrademarkAttribute.NativeFieldInfoPtr_m_trademark), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeFieldInfoPtr_m_trademark;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
