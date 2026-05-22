using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Internal
{
	// Token: 0x020001E7 RID: 487
	public static class ControllerTemplateFactory : Object
	{
		// Token: 0x0600390C RID: 14604 RVA: 0x000D4DBC File Offset: 0x000D2FBC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateFactory()
		{
			Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Internal", "ControllerTemplateFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr);
			ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, "_defaultTemplateTypes");
			ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, "_defaultTemplateInterfaceTypes");
			ControllerTemplateFactory.NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100668050);
			ControllerTemplateFactory.NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100668051);
			ControllerTemplateFactory.NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100668052);
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x000D4E50 File Offset: 0x000D3050
		public unsafe static Il2CppReferenceArray<Type> templateTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88722, XrefRangeEnd = 88726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x000D4E84 File Offset: 0x000D3084
		public unsafe static Il2CppReferenceArray<Type> templateInterfaceTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88726, XrefRangeEnd = 88730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x000D4EB8 File Offset: 0x000D30B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88784, RefRangeEnd = 88785, XrefRangeStart = 88730, XrefRangeEnd = 88784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IControllerTemplate Create(Guid typeGuid, Object payload)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeGuid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(payload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr3) : null;
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x000245D6 File Offset: 0x000227D6
		public ControllerTemplateFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x000D4F0C File Offset: 0x000D310C
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x000245DF File Offset: 0x000227DF
		public unsafe static Il2CppReferenceArray<Type> _defaultTemplateTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x000D4F34 File Offset: 0x000D3134
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x000245F1 File Offset: 0x000227F1
		public unsafe static Il2CppReferenceArray<Type> _defaultTemplateInterfaceTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeFieldInfoPtr__defaultTemplateTypes;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeFieldInfoPtr__defaultTemplateInterfaceTypes;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0;
	}
}
