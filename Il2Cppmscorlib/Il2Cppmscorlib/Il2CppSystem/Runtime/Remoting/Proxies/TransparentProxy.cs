using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020003AB RID: 939
	public class TransparentProxy : Object
	{
		// Token: 0x06003DE2 RID: 15842 RVA: 0x00124B90 File Offset: 0x00122D90
		// Note: this type is marked as 'beforefieldinit'.
		static TransparentProxy()
		{
			Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "TransparentProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr);
			TransparentProxy.NativeFieldInfoPtr__rp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_rp");
			TransparentProxy.NativeFieldInfoPtr__class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_class");
			TransparentProxy.NativeFieldInfoPtr__custom_type_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_custom_type_info");
			TransparentProxy.NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672471);
			TransparentProxy.NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672472);
			TransparentProxy.NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672473);
			TransparentProxy.NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672474);
			TransparentProxy.NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672475);
			TransparentProxy.NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672476);
			TransparentProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100672477);
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00124C88 File Offset: 0x00122E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221519, XrefRangeEnd = 221525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType GetProxyType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x00124CC8 File Offset: 0x00122EC8
		public unsafe bool IsContextBoundObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221525, XrefRangeEnd = 221533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x00124D04 File Offset: 0x00122F04
		public unsafe Context TargetContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00124D44 File Offset: 0x00122F44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221539, RefRangeEnd = 221541, XrefRangeStart = 221533, XrefRangeEnd = 221539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InCurrentContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00124D80 File Offset: 0x00122F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221541, XrefRangeEnd = 221567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00124DDC File Offset: 0x00122FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221567, XrefRangeEnd = 221594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, Object arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x00124E3C File Offset: 0x0012303C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransparentProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x00017129 File Offset: 0x00015329
		public TransparentProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06003DEB RID: 15851 RVA: 0x00124E78 File Offset: 0x00123078
		// (set) Token: 0x06003DEC RID: 15852 RVA: 0x00017132 File Offset: 0x00015332
		public unsafe RealProxy _rp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__rp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__rp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06003DED RID: 15853 RVA: 0x00124EA8 File Offset: 0x001230A8
		// (set) Token: 0x06003DEE RID: 15854 RVA: 0x00017151 File Offset: 0x00015351
		public unsafe RuntimeRemoteClassHandle _class
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__class);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__class)) = value;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06003DEF RID: 15855 RVA: 0x00124ED0 File Offset: 0x001230D0
		// (set) Token: 0x06003DF0 RID: 15856 RVA: 0x0001716C File Offset: 0x0001536C
		public unsafe bool _custom_type_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__custom_type_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__custom_type_info)) = value;
			}
		}

		// Token: 0x0400333A RID: 13114
		private static readonly IntPtr NativeFieldInfoPtr__rp;

		// Token: 0x0400333B RID: 13115
		private static readonly IntPtr NativeFieldInfoPtr__class;

		// Token: 0x0400333C RID: 13116
		private static readonly IntPtr NativeFieldInfoPtr__custom_type_info;

		// Token: 0x0400333D RID: 13117
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0;

		// Token: 0x0400333E RID: 13118
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0;

		// Token: 0x0400333F RID: 13119
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0;

		// Token: 0x04003340 RID: 13120
		private static readonly IntPtr NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0;

		// Token: 0x04003341 RID: 13121
		private static readonly IntPtr NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0;

		// Token: 0x04003342 RID: 13122
		private static readonly IntPtr NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0;

		// Token: 0x04003343 RID: 13123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
