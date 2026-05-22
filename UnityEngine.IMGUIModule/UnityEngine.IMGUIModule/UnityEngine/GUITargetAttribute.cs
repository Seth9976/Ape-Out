using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	public class GUITargetAttribute : Attribute
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00011578 File Offset: 0x0000F778
		// Note: this type is marked as 'beforefieldinit'.
		static GUITargetAttribute()
		{
			Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUITargetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr);
			GUITargetAttribute.NativeFieldInfoPtr_displayMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr, "displayMask");
			GUITargetAttribute.NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr, 100663666);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000115D0 File Offset: 0x0000F7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509311, XrefRangeEnd = 509321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGUITargetAttrValue(Type klass, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUITargetAttribute.NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003921 File Offset: 0x00001B21
		public GUITargetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00011624 File Offset: 0x0000F824
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0000392A File Offset: 0x00001B2A
		public unsafe int displayMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUITargetAttribute.NativeFieldInfoPtr_displayMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUITargetAttribute.NativeFieldInfoPtr_displayMask)) = value;
			}
		}

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_displayMask;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0;
	}
}
