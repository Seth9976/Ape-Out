using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x0200000D RID: 13
	public class ICurvesOwner : Il2CppObjectBase
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00008294 File Offset: 0x00006494
		// Note: this type is marked as 'beforefieldinit'.
		static ICurvesOwner()
		{
			Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ICurvesOwner");
			ICurvesOwner.NativeMethodInfoPtr_get_curves_Public_Abstract_Virtual_New_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr, 100663462);
			ICurvesOwner.NativeMethodInfoPtr_get_hasCurves_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr, 100663463);
			ICurvesOwner.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr, 100663464);
			ICurvesOwner.NativeMethodInfoPtr_CreateCurves_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr, 100663465);
			ICurvesOwner.NativeMethodInfoPtr_get_defaultCurvesName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr, 100663466);
			ICurvesOwner.NativeMethodInfoPtr_get_asset_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr, 100663467);
			ICurvesOwner.NativeMethodInfoPtr_get_assetOwner_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr, 100663468);
			ICurvesOwner.NativeMethodInfoPtr_get_targetTrack_Public_Abstract_Virtual_New_get_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICurvesOwner>.NativeClassPtr, 100663469);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000835C File Offset: 0x0000655C
		public unsafe virtual AnimationClip curves
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICurvesOwner.NativeMethodInfoPtr_get_curves_Public_Abstract_Virtual_New_get_AnimationClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000083A8 File Offset: 0x000065A8
		public unsafe virtual bool hasCurves
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICurvesOwner.NativeMethodInfoPtr_get_hasCurves_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000083F0 File Offset: 0x000065F0
		public unsafe virtual double duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICurvesOwner.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00008438 File Offset: 0x00006638
		[CallerCount(0)]
		public unsafe virtual void CreateCurves(string curvesClipName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(curvesClipName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICurvesOwner.NativeMethodInfoPtr_CreateCurves_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00008488 File Offset: 0x00006688
		public unsafe virtual string defaultCurvesName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICurvesOwner.NativeMethodInfoPtr_get_defaultCurvesName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000084CC File Offset: 0x000066CC
		public unsafe virtual Object asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICurvesOwner.NativeMethodInfoPtr_get_asset_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00008518 File Offset: 0x00006718
		public unsafe virtual Object assetOwner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICurvesOwner.NativeMethodInfoPtr_get_assetOwner_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00008564 File Offset: 0x00006764
		public unsafe virtual TrackAsset targetTrack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICurvesOwner.NativeMethodInfoPtr_get_targetTrack_Public_Abstract_Virtual_New_get_TrackAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002568 File Offset: 0x00000768
		public ICurvesOwner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_curves_Public_Abstract_Virtual_New_get_AnimationClip_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_get_hasCurves_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_CreateCurves_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultCurvesName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_assetOwner_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_targetTrack_Public_Abstract_Virtual_New_get_TrackAsset_0;
	}
}
