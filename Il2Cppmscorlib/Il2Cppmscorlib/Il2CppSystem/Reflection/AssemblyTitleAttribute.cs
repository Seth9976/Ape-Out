using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000194 RID: 404
	public sealed class AssemblyTitleAttribute : Attribute
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x000A1DB0 File Offset: 0x0009FFB0
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyTitleAttribute()
		{
			Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyTitleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr);
			AssemblyTitleAttribute.NativeFieldInfoPtr_m_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr, "m_title");
			AssemblyTitleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr, 100668025);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000A1E08 File Offset: 0x000A0008
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyTitleAttribute(string title)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyTitleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00009721 File Offset: 0x00007921
		public AssemblyTitleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x000A1E54 File Offset: 0x000A0054
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0000972A File Offset: 0x0000792A
		public unsafe string m_title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTitleAttribute.NativeFieldInfoPtr_m_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTitleAttribute.NativeFieldInfoPtr_m_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeFieldInfoPtr_m_title;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
