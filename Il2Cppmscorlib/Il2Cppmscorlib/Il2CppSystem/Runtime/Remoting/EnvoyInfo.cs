using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038E RID: 910
	[Serializable]
	public class EnvoyInfo : Object
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x0011E4F8 File Offset: 0x0011C6F8
		// Note: this type is marked as 'beforefieldinit'.
		static EnvoyInfo()
		{
			Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "EnvoyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr);
			EnvoyInfo.NativeFieldInfoPtr_envoySinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, "envoySinks");
			EnvoyInfo.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, 100672256);
			EnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, 100672257);
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0011E564 File Offset: 0x0011C764
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvoyInfo(IMessageSink sinks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyInfo.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x0011E5B0 File Offset: 0x0011C7B0
		public unsafe virtual IMessageSink EnvoySinks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00016705 File Offset: 0x00014905
		public EnvoyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x0011E5F0 File Offset: 0x0011C7F0
		// (set) Token: 0x06003C37 RID: 15415 RVA: 0x0001670E File Offset: 0x0001490E
		public unsafe IMessageSink envoySinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvoyInfo.NativeFieldInfoPtr_envoySinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvoyInfo.NativeFieldInfoPtr_envoySinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeFieldInfoPtr_envoySinks;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0;

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0;
	}
}
