using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR
{
	// Token: 0x02000012 RID: 18
	public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
	{
		// Token: 0x0600010A RID: 266 RVA: 0x00004E04 File Offset: 0x00003004
		// Note: this type is marked as 'beforefieldinit'.
		static XRInputSubsystem()
		{
			Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRInputSubsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr);
			XRInputSubsystem.NativeFieldInfoPtr_trackingOriginUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, "trackingOriginUpdated");
			XRInputSubsystem.NativeFieldInfoPtr_boundaryChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, "boundaryChanged");
			XRInputSubsystem.NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663333);
			XRInputSubsystem.NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663334);
			XRInputSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663335);
			XRInputSubsystem.GetIndexDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.GetIndexDelegate>("UnityEngine.XR.XRInputSubsystem::GetIndex");
			XRInputSubsystem.TryRecenterDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.TryRecenterDelegate>("UnityEngine.XR.XRInputSubsystem::TryRecenter");
			XRInputSubsystem.TrySetTrackingOriginModeDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.TrySetTrackingOriginModeDelegate>("UnityEngine.XR.XRInputSubsystem::TrySetTrackingOriginMode");
			XRInputSubsystem.GetTrackingOriginModeDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.GetTrackingOriginModeDelegate>("UnityEngine.XR.XRInputSubsystem::GetTrackingOriginMode");
			XRInputSubsystem.GetSupportedTrackingOriginModesDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.GetSupportedTrackingOriginModesDelegate>("UnityEngine.XR.XRInputSubsystem::GetSupportedTrackingOriginModes");
			XRInputSubsystem.TryGetBoundaryPoints_AsListDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.TryGetBoundaryPoints_AsListDelegate>("UnityEngine.XR.XRInputSubsystem::TryGetBoundaryPoints_AsList");
			XRInputSubsystem.TryGetDeviceIds_AsListDelegateField = IL2CPP.ResolveICall<XRInputSubsystem.TryGetDeviceIds_AsListDelegate>("UnityEngine.XR.XRInputSubsystem::TryGetDeviceIds_AsList");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004F04 File Offset: 0x00003104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535097, XrefRangeEnd = 535106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref internalPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystem.NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004F38 File Offset: 0x00003138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535106, XrefRangeEnd = 535115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeBoundaryChangedEvent(IntPtr internalPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref internalPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystem.NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004F6C File Offset: 0x0000316C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535115, XrefRangeEnd = 535116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRInputSubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002A28 File Offset: 0x00000C28
		public XRInputSubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00004FA8 File Offset: 0x000031A8
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002A31 File Offset: 0x00000C31
		public unsafe Action<XRInputSubsystem> trackingOriginUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRInputSubsystem.NativeFieldInfoPtr_trackingOriginUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRInputSubsystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRInputSubsystem.NativeFieldInfoPtr_trackingOriginUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00004FD8 File Offset: 0x000031D8
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002A50 File Offset: 0x00000C50
		public unsafe Action<XRInputSubsystem> boundaryChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRInputSubsystem.NativeFieldInfoPtr_boundaryChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<XRInputSubsystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRInputSubsystem.NativeFieldInfoPtr_boundaryChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002A6F File Offset: 0x00000C6F
		public uint GetIndex()
		{
			return XRInputSubsystem.GetIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002A81 File Offset: 0x00000C81
		public bool TryRecenter()
		{
			return XRInputSubsystem.TryRecenterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002A93 File Offset: 0x00000C93
		public bool TryGetInputDevices(List<InputDevice> devices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002AA0 File Offset: 0x00000CA0
		public bool TrySetTrackingOriginMode(TrackingOriginModeFlags origin)
		{
			return XRInputSubsystem.TrySetTrackingOriginModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), origin);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002AB3 File Offset: 0x00000CB3
		public TrackingOriginModeFlags GetTrackingOriginMode()
		{
			return XRInputSubsystem.GetTrackingOriginModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public TrackingOriginModeFlags GetSupportedTrackingOriginModes()
		{
			return XRInputSubsystem.GetSupportedTrackingOriginModesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005008 File Offset: 0x00003208
		public bool TryGetBoundaryPoints(List<Vector3> boundaryPoints)
		{
			bool flag = boundaryPoints == null;
			if (flag)
			{
				throw new ArgumentNullException("boundaryPoints");
			}
			return this.TryGetBoundaryPoints_AsList(boundaryPoints);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002AD7 File Offset: 0x00000CD7
		public bool TryGetBoundaryPoints_AsList(List<Vector3> boundaryPoints)
		{
			return XRInputSubsystem.TryGetBoundaryPoints_AsListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(boundaryPoints));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002AEF File Offset: 0x00000CEF
		public void add_trackingOriginUpdated(Action<XRInputSubsystem> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002AFC File Offset: 0x00000CFC
		public void remove_trackingOriginUpdated(Action<XRInputSubsystem> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002B09 File Offset: 0x00000D09
		public void add_boundaryChanged(Action<XRInputSubsystem> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002B16 File Offset: 0x00000D16
		public void remove_boundaryChanged(Action<XRInputSubsystem> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002B23 File Offset: 0x00000D23
		public void TryGetDeviceIds_AsList(List<ulong> deviceIds)
		{
			XRInputSubsystem.TryGetDeviceIds_AsListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(deviceIds));
		}

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_trackingOriginUpdated;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_boundaryChanged;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000CF RID: 207
		private static readonly XRInputSubsystem.GetIndexDelegate GetIndexDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly XRInputSubsystem.TryRecenterDelegate TryRecenterDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly XRInputSubsystem.TrySetTrackingOriginModeDelegate TrySetTrackingOriginModeDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly XRInputSubsystem.GetTrackingOriginModeDelegate GetTrackingOriginModeDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly XRInputSubsystem.GetSupportedTrackingOriginModesDelegate GetSupportedTrackingOriginModesDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly XRInputSubsystem.TryGetBoundaryPoints_AsListDelegate TryGetBoundaryPoints_AsListDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly XRInputSubsystem.TryGetDeviceIds_AsListDelegate TryGetDeviceIds_AsListDelegateField;

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x0600020D RID: 525
		private delegate uint GetIndexDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x0600020F RID: 527
		private delegate bool TryRecenterDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000211 RID: 529
		private delegate bool TrySetTrackingOriginModeDelegate(IntPtr @this, TrackingOriginModeFlags origin);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000213 RID: 531
		private delegate TrackingOriginModeFlags GetTrackingOriginModeDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000215 RID: 533
		private delegate TrackingOriginModeFlags GetSupportedTrackingOriginModesDelegate(IntPtr @this);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000217 RID: 535
		private delegate bool TryGetBoundaryPoints_AsListDelegate(IntPtr @this, IntPtr boundaryPoints);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000219 RID: 537
		private delegate void TryGetDeviceIds_AsListDelegate(IntPtr @this, IntPtr deviceIds);
	}
}
