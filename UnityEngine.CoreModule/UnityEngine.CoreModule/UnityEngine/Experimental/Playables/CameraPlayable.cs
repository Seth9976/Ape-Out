using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020001A2 RID: 418
	[StructLayout(2)]
	public struct CameraPlayable
	{
		// Token: 0x06001F0A RID: 7946 RVA: 0x0007269C File Offset: 0x0007089C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraPlayable()
		{
			Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "CameraPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr);
			CameraPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, "m_Handle");
			CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100666152);
			CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100666153);
			CameraPlayable.GetCameraInternalDelegateField = IL2CPP.ResolveICall<CameraPlayable.GetCameraInternalDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::GetCameraInternal");
			CameraPlayable.SetCameraInternalDelegateField = IL2CPP.ResolveICall<CameraPlayable.SetCameraInternalDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::SetCameraInternal");
			CameraPlayable.InternalCreateCameraPlayableDelegateField = IL2CPP.ResolveICall<CameraPlayable.InternalCreateCameraPlayableDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::InternalCreateCameraPlayable");
			CameraPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<CameraPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::ValidateType");
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00072744 File Offset: 0x00070944
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00072774 File Offset: 0x00070974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504696, XrefRangeEnd = 504703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CameraPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x000101AF File Offset: 0x0000E3AF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x000727B4 File Offset: 0x000709B4
		public static CameraPlayable Create(UnityEngine.Playables.PlayableGraph graph, Camera camera)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = CameraPlayable.CreateHandle(graph, camera);
			return new CameraPlayable(playableHandle);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x000727D4 File Offset: 0x000709D4
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, Camera camera)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !CameraPlayable.InternalCreateCameraPlayable(ref graph, camera, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00072808 File Offset: 0x00070A08
		public static implicit operator UnityEngine.Playables.Playable(CameraPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00072828 File Offset: 0x00070A28
		public static explicit operator CameraPlayable(UnityEngine.Playables.Playable playable)
		{
			return new CameraPlayable(playable.GetHandle());
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00072848 File Offset: 0x00070A48
		public Camera GetCamera()
		{
			return CameraPlayable.GetCameraInternal(ref this.m_Handle);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000101C1 File Offset: 0x0000E3C1
		public void SetCamera(Camera value)
		{
			CameraPlayable.SetCameraInternal(ref this.m_Handle, value);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00072868 File Offset: 0x00070A68
		public static Camera GetCameraInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			IntPtr intPtr = CameraPlayable.GetCameraInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000101D1 File Offset: 0x0000E3D1
		public static void SetCameraInternal(ref UnityEngine.Playables.PlayableHandle hdl, Camera camera)
		{
			CameraPlayable.SetCameraInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000101E4 File Offset: 0x0000E3E4
		public static bool InternalCreateCameraPlayable(ref UnityEngine.Playables.PlayableGraph graph, Camera camera, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return CameraPlayable.InternalCreateCameraPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(camera), ref handle);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x000101F8 File Offset: 0x0000E3F8
		public static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return CameraPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0;

		// Token: 0x04001884 RID: 6276
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04001885 RID: 6277
		private static readonly CameraPlayable.GetCameraInternalDelegate GetCameraInternalDelegateField;

		// Token: 0x04001886 RID: 6278
		private static readonly CameraPlayable.SetCameraInternalDelegate SetCameraInternalDelegateField;

		// Token: 0x04001887 RID: 6279
		private static readonly CameraPlayable.InternalCreateCameraPlayableDelegate InternalCreateCameraPlayableDelegateField;

		// Token: 0x04001888 RID: 6280
		private static readonly CameraPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000A48 RID: 2632
		// (Invoke) Token: 0x06003310 RID: 13072
		private delegate IntPtr GetCameraInternalDelegate(IntPtr hdl);

		// Token: 0x02000A49 RID: 2633
		// (Invoke) Token: 0x06003312 RID: 13074
		private delegate void SetCameraInternalDelegate(IntPtr hdl, IntPtr camera);

		// Token: 0x02000A4A RID: 2634
		// (Invoke) Token: 0x06003314 RID: 13076
		private delegate bool InternalCreateCameraPlayableDelegate(IntPtr graph, IntPtr camera, IntPtr handle);

		// Token: 0x02000A4B RID: 2635
		// (Invoke) Token: 0x06003316 RID: 13078
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
