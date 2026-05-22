using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001FE RID: 510
	public class ThemedElement : MonoBehaviour
	{
		// Token: 0x06003EDC RID: 16092 RVA: 0x000EB2F8 File Offset: 0x000E94F8
		// Note: this type is marked as 'beforefieldinit'.
		static ThemedElement()
		{
			Il2CppClassPointerStore<ThemedElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ThemedElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemedElement>.NativeClassPtr);
			ThemedElement.NativeFieldInfoPtr__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemedElement>.NativeClassPtr, "_elements");
			ThemedElement.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemedElement>.NativeClassPtr, 100669296);
			ThemedElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemedElement>.NativeClassPtr, 100669297);
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x000EB364 File Offset: 0x000E9564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99591, XrefRangeEnd = 99592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemedElement.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x000EB398 File Offset: 0x000E9598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThemedElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemedElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemedElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00026BB4 File Offset: 0x00024DB4
		public ThemedElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x000EB3D4 File Offset: 0x000E95D4
		// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x00026BBD File Offset: 0x00024DBD
		public unsafe Il2CppReferenceArray<ThemedElement.ElementInfo> _elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemedElement.NativeFieldInfoPtr__elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ThemedElement.ElementInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemedElement.NativeFieldInfoPtr__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeFieldInfoPtr__elements;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000393 RID: 915
		[Serializable]
		public class ElementInfo : global::Il2CppSystem.Object
		{
			// Token: 0x06005814 RID: 22548 RVA: 0x0013F790 File Offset: 0x0013D990
			// Note: this type is marked as 'beforefieldinit'.
			static ElementInfo()
			{
				Il2CppClassPointerStore<ThemedElement.ElementInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemedElement>.NativeClassPtr, "ElementInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemedElement.ElementInfo>.NativeClassPtr);
				ThemedElement.ElementInfo.NativeFieldInfoPtr__themeClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemedElement.ElementInfo>.NativeClassPtr, "_themeClass");
				ThemedElement.ElementInfo.NativeFieldInfoPtr__component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemedElement.ElementInfo>.NativeClassPtr, "_component");
				ThemedElement.ElementInfo.NativeMethodInfoPtr_get_themeClass_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemedElement.ElementInfo>.NativeClassPtr, 100669298);
				ThemedElement.ElementInfo.NativeMethodInfoPtr_get_component_Public_get_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemedElement.ElementInfo>.NativeClassPtr, 100669299);
				ThemedElement.ElementInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemedElement.ElementInfo>.NativeClassPtr, 100669300);
			}

			// Token: 0x17002039 RID: 8249
			// (get) Token: 0x06005815 RID: 22549 RVA: 0x0013F820 File Offset: 0x0013DA20
			public unsafe string themeClass
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemedElement.ElementInfo.NativeMethodInfoPtr_get_themeClass_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700203A RID: 8250
			// (get) Token: 0x06005816 RID: 22550 RVA: 0x0013F858 File Offset: 0x0013DA58
			public unsafe Component component
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemedElement.ElementInfo.NativeMethodInfoPtr_get_component_Public_get_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
				}
			}

			// Token: 0x06005817 RID: 22551 RVA: 0x0013F898 File Offset: 0x0013DA98
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ElementInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemedElement.ElementInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemedElement.ElementInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005818 RID: 22552 RVA: 0x00032965 File Offset: 0x00030B65
			public ElementInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002037 RID: 8247
			// (get) Token: 0x06005819 RID: 22553 RVA: 0x0013F8D4 File Offset: 0x0013DAD4
			// (set) Token: 0x0600581A RID: 22554 RVA: 0x0003296E File Offset: 0x00030B6E
			public unsafe string _themeClass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemedElement.ElementInfo.NativeFieldInfoPtr__themeClass);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemedElement.ElementInfo.NativeFieldInfoPtr__themeClass), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002038 RID: 8248
			// (get) Token: 0x0600581B RID: 22555 RVA: 0x0013F8FC File Offset: 0x0013DAFC
			// (set) Token: 0x0600581C RID: 22556 RVA: 0x0003298D File Offset: 0x00030B8D
			public unsafe Component _component
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemedElement.ElementInfo.NativeFieldInfoPtr__component);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThemedElement.ElementInfo.NativeFieldInfoPtr__component), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A7E RID: 14974
			private static readonly IntPtr NativeFieldInfoPtr__themeClass;

			// Token: 0x04003A7F RID: 14975
			private static readonly IntPtr NativeFieldInfoPtr__component;

			// Token: 0x04003A80 RID: 14976
			private static readonly IntPtr NativeMethodInfoPtr_get_themeClass_Public_get_String_0;

			// Token: 0x04003A81 RID: 14977
			private static readonly IntPtr NativeMethodInfoPtr_get_component_Public_get_Component_0;

			// Token: 0x04003A82 RID: 14978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
