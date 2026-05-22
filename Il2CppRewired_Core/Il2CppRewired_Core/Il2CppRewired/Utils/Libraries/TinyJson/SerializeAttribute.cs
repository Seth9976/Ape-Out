using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Libraries.TinyJson
{
	// Token: 0x020001DA RID: 474
	public class SerializeAttribute : Attribute
	{
		// Token: 0x060030DE RID: 12510 RVA: 0x000F3108 File Offset: 0x000F1308
		// Note: this type is marked as 'beforefieldinit'.
		static SerializeAttribute()
		{
			Il2CppClassPointerStore<SerializeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Libraries.TinyJson", "SerializeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeAttribute>.NativeClassPtr);
			SerializeAttribute.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeAttribute>.NativeClassPtr, "Name");
			SerializeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeAttribute>.NativeClassPtr, 100675749);
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000F3160 File Offset: 0x000F1360
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x000118DC File Offset: 0x0000FADC
		public SerializeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x000F319C File Offset: 0x000F139C
		// (set) Token: 0x060030E2 RID: 12514 RVA: 0x000118E5 File Offset: 0x0000FAE5
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializeAttribute.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializeAttribute.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
