using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D4 RID: 980
	[Serializable]
	public class ContextLevelActivator : Object
	{
		// Token: 0x06003F7B RID: 16251 RVA: 0x0012A638 File Offset: 0x00128838
		// Note: this type is marked as 'beforefieldinit'.
		static ContextLevelActivator()
		{
			Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "ContextLevelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr);
			ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, "m_NextActivator");
			ContextLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100672675);
			ContextLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100672676);
			ContextLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100672677);
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x0012A6B8 File Offset: 0x001288B8
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextLevelActivator(IActivator next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06003F7D RID: 16253 RVA: 0x0012A704 File Offset: 0x00128904
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x0012A744 File Offset: 0x00128944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223599, XrefRangeEnd = 223628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x00017BB3 File Offset: 0x00015DB3
		public ContextLevelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06003F80 RID: 16256 RVA: 0x0012A794 File Offset: 0x00128994
		// (set) Token: 0x06003F81 RID: 16257 RVA: 0x00017BBC File Offset: 0x00015DBC
		public unsafe IActivator m_NextActivator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003442 RID: 13378
		private static readonly IntPtr NativeFieldInfoPtr_m_NextActivator;

		// Token: 0x04003443 RID: 13379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IActivator_0;

		// Token: 0x04003444 RID: 13380
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x04003445 RID: 13381
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}
