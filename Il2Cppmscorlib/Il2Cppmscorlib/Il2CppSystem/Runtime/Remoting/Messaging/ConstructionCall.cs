using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Activation;
using Il2CppSystem.Runtime.Remoting.Proxies;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EE RID: 1006
	[Serializable]
	public class ConstructionCall : MethodCall
	{
		// Token: 0x060040B6 RID: 16566 RVA: 0x0012E76C File Offset: 0x0012C96C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionCall()
		{
			Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ConstructionCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr);
			ConstructionCall.NativeFieldInfoPtr__activator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activator");
			ConstructionCall.NativeFieldInfoPtr__activationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationAttributes");
			ConstructionCall.NativeFieldInfoPtr__contextProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_contextProperties");
			ConstructionCall.NativeFieldInfoPtr__activationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationType");
			ConstructionCall.NativeFieldInfoPtr__activationTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationTypeName");
			ConstructionCall.NativeFieldInfoPtr__isContextOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_isContextOk");
			ConstructionCall.NativeFieldInfoPtr__sourceProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_sourceProxy");
			ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672800);
			ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672801);
			ConstructionCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672802);
			ConstructionCall.NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672803);
			ConstructionCall.NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672804);
			ConstructionCall.NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672805);
			ConstructionCall.NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672806);
			ConstructionCall.NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672807);
			ConstructionCall.NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672808);
			ConstructionCall.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672809);
			ConstructionCall.NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672810);
			ConstructionCall.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672811);
			ConstructionCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672812);
			ConstructionCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672813);
			ConstructionCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672814);
			ConstructionCall.NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672815);
			ConstructionCall.NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672816);
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x0012E97C File Offset: 0x0012CB7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224465, RefRangeEnd = 224467, XrefRangeStart = 224465, XrefRangeEnd = 224465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCall(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x0012E9C8 File Offset: 0x0012CBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224467, XrefRangeEnd = 224470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCall(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x0012EA2C File Offset: 0x0012CC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224470, XrefRangeEnd = 224478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x0012EA68 File Offset: 0x0012CC68
		// (set) Token: 0x060040BB RID: 16571 RVA: 0x0012EAA4 File Offset: 0x0012CCA4
		public unsafe bool IsContextOk
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x0012EAE4 File Offset: 0x0012CCE4
		public unsafe virtual Type ActivationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224478, XrefRangeEnd = 224487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x060040BD RID: 16573 RVA: 0x0012EB24 File Offset: 0x0012CD24
		public unsafe virtual string ActivationTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x0012EB5C File Offset: 0x0012CD5C
		// (set) Token: 0x060040BF RID: 16575 RVA: 0x0012EB9C File Offset: 0x0012CD9C
		public unsafe virtual IActivator Activator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x0012EBE0 File Offset: 0x0012CDE0
		public unsafe virtual Il2CppReferenceArray<Object> CallSiteActivationAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x0012EC20 File Offset: 0x0012CE20
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActivationAttributes(Il2CppReferenceArray<Object> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x060040C2 RID: 16578 RVA: 0x0012EC64 File Offset: 0x0012CE64
		public unsafe virtual IList ContextProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224487, XrefRangeEnd = 224491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x0012ECA4 File Offset: 0x0012CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224491, XrefRangeEnd = 224507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitMethodProperty(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x0012ED04 File Offset: 0x0012CF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224507, XrefRangeEnd = 224553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x060040C5 RID: 16581 RVA: 0x0012ED68 File Offset: 0x0012CF68
		public unsafe override IDictionary Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x0012EDB4 File Offset: 0x0012CFB4
		// (set) Token: 0x060040C7 RID: 16583 RVA: 0x0012EDF4 File Offset: 0x0012CFF4
		public unsafe RemotingProxy SourceProxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemotingProxy>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 224553, RefRangeEnd = 224561, XrefRangeStart = 224553, XrefRangeEnd = 224553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00018579 File Offset: 0x00016779
		public ConstructionCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x0012EE38 File Offset: 0x0012D038
		// (set) Token: 0x060040CA RID: 16586 RVA: 0x00018582 File Offset: 0x00016782
		public unsafe IActivator _activator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x0012EE68 File Offset: 0x0012D068
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x000185A1 File Offset: 0x000167A1
		public unsafe Il2CppReferenceArray<Object> _activationAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x0012EE98 File Offset: 0x0012D098
		// (set) Token: 0x060040CE RID: 16590 RVA: 0x000185C0 File Offset: 0x000167C0
		public unsafe IList _contextProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__contextProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__contextProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x0012EEC8 File Offset: 0x0012D0C8
		// (set) Token: 0x060040D0 RID: 16592 RVA: 0x000185DF File Offset: 0x000167DF
		public unsafe Type _activationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x0012EEF8 File Offset: 0x0012D0F8
		// (set) Token: 0x060040D2 RID: 16594 RVA: 0x000185FE File Offset: 0x000167FE
		public unsafe string _activationTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x0012EF20 File Offset: 0x0012D120
		// (set) Token: 0x060040D4 RID: 16596 RVA: 0x0001861D File Offset: 0x0001681D
		public unsafe bool _isContextOk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__isContextOk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__isContextOk)) = value;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x0012EF48 File Offset: 0x0012D148
		// (set) Token: 0x060040D6 RID: 16598 RVA: 0x00018638 File Offset: 0x00016838
		public unsafe RemotingProxy _sourceProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__sourceProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemotingProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__sourceProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003505 RID: 13573
		private static readonly IntPtr NativeFieldInfoPtr__activator;

		// Token: 0x04003506 RID: 13574
		private static readonly IntPtr NativeFieldInfoPtr__activationAttributes;

		// Token: 0x04003507 RID: 13575
		private static readonly IntPtr NativeFieldInfoPtr__contextProperties;

		// Token: 0x04003508 RID: 13576
		private static readonly IntPtr NativeFieldInfoPtr__activationType;

		// Token: 0x04003509 RID: 13577
		private static readonly IntPtr NativeFieldInfoPtr__activationTypeName;

		// Token: 0x0400350A RID: 13578
		private static readonly IntPtr NativeFieldInfoPtr__isContextOk;

		// Token: 0x0400350B RID: 13579
		private static readonly IntPtr NativeFieldInfoPtr__sourceProxy;

		// Token: 0x0400350C RID: 13580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x0400350D RID: 13581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400350E RID: 13582
		private static readonly IntPtr NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0;

		// Token: 0x0400350F RID: 13583
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0;

		// Token: 0x04003510 RID: 13584
		private static readonly IntPtr NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0;

		// Token: 0x04003511 RID: 13585
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04003512 RID: 13586
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003513 RID: 13587
		private static readonly IntPtr NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x04003514 RID: 13588
		private static readonly IntPtr NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0;

		// Token: 0x04003515 RID: 13589
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003516 RID: 13590
		private static readonly IntPtr NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003517 RID: 13591
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0;

		// Token: 0x04003518 RID: 13592
		private static readonly IntPtr NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0;

		// Token: 0x04003519 RID: 13593
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400351A RID: 13594
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0;

		// Token: 0x0400351B RID: 13595
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0;

		// Token: 0x0400351C RID: 13596
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0;
	}
}
