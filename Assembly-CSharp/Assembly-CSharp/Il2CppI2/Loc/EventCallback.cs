using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200022D RID: 557
	[Serializable]
	public class EventCallback : global::Il2CppSystem.Object
	{
		// Token: 0x060042AA RID: 17066 RVA: 0x000F7C90 File Offset: 0x000F5E90
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallback()
		{
			Il2CppClassPointerStore<EventCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "EventCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallback>.NativeClassPtr);
			EventCallback.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallback>.NativeClassPtr, "Target");
			EventCallback.NativeFieldInfoPtr_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallback>.NativeClassPtr, "MethodName");
			EventCallback.NativeMethodInfoPtr_Execute_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback>.NativeClassPtr, 100669827);
			EventCallback.NativeMethodInfoPtr_HasCallback_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback>.NativeClassPtr, 100669828);
			EventCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback>.NativeClassPtr, 100669829);
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x000F7D24 File Offset: 0x000F5F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107348, XrefRangeEnd = 107354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(global::UnityEngine.Object Sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallback.NativeMethodInfoPtr_Execute_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x000F7D68 File Offset: 0x000F5F68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107366, RefRangeEnd = 107369, XrefRangeStart = 107354, XrefRangeEnd = 107366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallback.NativeMethodInfoPtr_HasCallback_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000F7DA4 File Offset: 0x000F5FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107369, XrefRangeEnd = 107371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x00028915 File Offset: 0x00026B15
		public EventCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x000F7DE0 File Offset: 0x000F5FE0
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x0002891E File Offset: 0x00026B1E
		public unsafe MonoBehaviour Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallback.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallback.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x060042B1 RID: 17073 RVA: 0x000F7E10 File Offset: 0x000F6010
		// (set) Token: 0x060042B2 RID: 17074 RVA: 0x0002893D File Offset: 0x00026B3D
		public unsafe string MethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallback.NativeFieldInfoPtr_MethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallback.NativeFieldInfoPtr_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeFieldInfoPtr_MethodName;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_Object_0;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeMethodInfoPtr_HasCallback_Public_Boolean_0;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
