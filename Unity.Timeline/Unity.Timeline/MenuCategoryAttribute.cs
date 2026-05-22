using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x02000044 RID: 68
	public class MenuCategoryAttribute : Attribute
	{
		// Token: 0x060004B6 RID: 1206 RVA: 0x00016EAC File Offset: 0x000150AC
		// Note: this type is marked as 'beforefieldinit'.
		static MenuCategoryAttribute()
		{
			Il2CppClassPointerStore<MenuCategoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "MenuCategoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuCategoryAttribute>.NativeClassPtr);
			MenuCategoryAttribute.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuCategoryAttribute>.NativeClassPtr, "category");
			MenuCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuCategoryAttribute>.NativeClassPtr, 100664074);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00016F04 File Offset: 0x00015104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479334, XrefRangeEnd = 479336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MenuCategoryAttribute(string category)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuCategoryAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000038D7 File Offset: 0x00001AD7
		public MenuCategoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00016F50 File Offset: 0x00015150
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x000038E0 File Offset: 0x00001AE0
		public unsafe string category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuCategoryAttribute.NativeFieldInfoPtr_category);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuCategoryAttribute.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
