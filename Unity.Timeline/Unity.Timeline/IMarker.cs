using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x02000023 RID: 35
	public class IMarker : Il2CppObjectBase
	{
		// Token: 0x06000395 RID: 917 RVA: 0x000129E4 File Offset: 0x00010BE4
		// Note: this type is marked as 'beforefieldinit'.
		static IMarker()
		{
			Il2CppClassPointerStore<IMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IMarker");
			IMarker.NativeMethodInfoPtr_get_time_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMarker>.NativeClassPtr, 100663911);
			IMarker.NativeMethodInfoPtr_set_time_Public_Abstract_Virtual_New_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMarker>.NativeClassPtr, 100663912);
			IMarker.NativeMethodInfoPtr_get_parent_Public_Abstract_Virtual_New_get_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMarker>.NativeClassPtr, 100663913);
			IMarker.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMarker>.NativeClassPtr, 100663914);
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00012A5C File Offset: 0x00010C5C
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00012AA4 File Offset: 0x00010CA4
		public unsafe virtual double time
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMarker.NativeMethodInfoPtr_get_time_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMarker.NativeMethodInfoPtr_set_time_Public_Abstract_Virtual_New_set_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00012AF0 File Offset: 0x00010CF0
		public unsafe virtual TrackAsset parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMarker.NativeMethodInfoPtr_get_parent_Public_Abstract_Virtual_New_get_TrackAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00012B3C File Offset: 0x00010D3C
		[CallerCount(0)]
		public unsafe virtual void Initialize(TrackAsset parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMarker.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_TrackAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000320B File Offset: 0x0000140B
		public IMarker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_Abstract_Virtual_New_set_Void_Double_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_Abstract_Virtual_New_get_TrackAsset_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_TrackAsset_0;
	}
}
