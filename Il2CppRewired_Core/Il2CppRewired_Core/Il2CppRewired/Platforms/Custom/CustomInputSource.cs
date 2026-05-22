using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppRewired.Platforms.Custom
{
	// Token: 0x0200009B RID: 155
	public class CustomInputSource : Object
	{
		// Token: 0x0600126C RID: 4716 RVA: 0x00071AF0 File Offset: 0x0006FCF0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomInputSource()
		{
			Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.Custom", "CustomInputSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr);
			CustomInputSource.NativeFieldInfoPtr_kjBsrXwNkKBemaKyhvRlDUviZoQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "kjBsrXwNkKBemaKyhvRlDUviZoQ");
			CustomInputSource.NativeFieldInfoPtr_xbbcnTFunfOiWypxpNAzMIkgDXj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "xbbcnTFunfOiWypxpNAzMIkgDXj");
			CustomInputSource.NativeFieldInfoPtr_IwUqVNlsQvUOJZsGUmkbMZGtcjM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "IwUqVNlsQvUOJZsGUmkbMZGtcjM");
			CustomInputSource.NativeFieldInfoPtr_QiffcAFtJEuLiqyzTvqImWyGeoE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "QiffcAFtJEuLiqyzTvqImWyGeoE");
			CustomInputSource.NativeFieldInfoPtr_bTTdrUgrDHYUeJnQITtlkdJOQXSa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "bTTdrUgrDHYUeJnQITtlkdJOQXSa");
			CustomInputSource.NativeFieldInfoPtr_SNSIvkupRMZWWmWZZRifMpkXUDw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "SNSIvkupRMZWWmWZZRifMpkXUDw");
			CustomInputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			CustomInputSource.NativeMethodInfoPtr_get_useApproximateMatching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666369);
			CustomInputSource.NativeMethodInfoPtr_set_useApproximateMatching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666370);
			CustomInputSource.NativeMethodInfoPtr_add__JoystickConnectedEvent_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666371);
			CustomInputSource.NativeMethodInfoPtr_remove__JoystickConnectedEvent_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666372);
			CustomInputSource.NativeMethodInfoPtr_add__JoystickDisconnectedEvent_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666373);
			CustomInputSource.NativeMethodInfoPtr_remove__JoystickDisconnectedEvent_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666374);
			CustomInputSource.NativeMethodInfoPtr_add_JoystickConnectedEvent_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666375);
			CustomInputSource.NativeMethodInfoPtr_remove_JoystickConnectedEvent_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666376);
			CustomInputSource.NativeMethodInfoPtr_add_JoystickDisconnectedEvent_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666377);
			CustomInputSource.NativeMethodInfoPtr_remove_JoystickDisconnectedEvent_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666378);
			CustomInputSource.NativeMethodInfoPtr_get_inputSource_Internal_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666379);
			CustomInputSource.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666380);
			CustomInputSource.NativeMethodInfoPtr_AddJoystick_Public_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666381);
			CustomInputSource.NativeMethodInfoPtr_RemoveJoystick_Public_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666382);
			CustomInputSource.NativeMethodInfoPtr_GetJoysticks_Public_IList_1_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666383);
			CustomInputSource.NativeMethodInfoPtr_OnJoystickConnected_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666384);
			CustomInputSource.NativeMethodInfoPtr_OnJoystickDisconnected_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666385);
			CustomInputSource.NativeMethodInfoPtr_VNnJpEzwJVPVMkjzptsRqXYRGvI_Internal_Il2CppReferenceArray_1_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666386);
			CustomInputSource.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666387);
			CustomInputSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666388);
			CustomInputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666389);
			CustomInputSource.NativeMethodInfoPtr_get_isReady_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666390);
			CustomInputSource.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, 100666391);
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00071D78 File Offset: 0x0006FF78
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x00071DB4 File Offset: 0x0006FFB4
		public unsafe bool useApproximateMatching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_get_useApproximateMatching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_set_useApproximateMatching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00071DF4 File Offset: 0x0006FFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262043, XrefRangeEnd = 262046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__JoystickConnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_add__JoystickConnectedEvent_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00071E38 File Offset: 0x00070038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262046, XrefRangeEnd = 262049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__JoystickConnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_remove__JoystickConnectedEvent_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00071E7C File Offset: 0x0007007C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262049, XrefRangeEnd = 262052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__JoystickDisconnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_add__JoystickDisconnectedEvent_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00071EC0 File Offset: 0x000700C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262052, XrefRangeEnd = 262055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__JoystickDisconnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_remove__JoystickDisconnectedEvent_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00071F04 File Offset: 0x00070104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_JoystickConnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_add_JoystickConnectedEvent_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00071F48 File Offset: 0x00070148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_JoystickConnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_remove_JoystickConnectedEvent_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00071F8C File Offset: 0x0007018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_JoystickDisconnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_add_JoystickDisconnectedEvent_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00071FD0 File Offset: 0x000701D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_JoystickDisconnectedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_remove_JoystickDisconnectedEvent_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00072014 File Offset: 0x00070214
		public unsafe InputSource inputSource
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_get_inputSource_Internal_get_InputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00072050 File Offset: 0x00070250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262090, RefRangeEnd = 262092, XrefRangeStart = 262055, XrefRangeEnd = 262090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomInputSource(int inputSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputSource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00072098 File Offset: 0x00070298
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262099, RefRangeEnd = 262101, XrefRangeStart = 262092, XrefRangeEnd = 262099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddJoystick(CustomInputSource.Joystick joystick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_AddJoystick_Public_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000720DC File Offset: 0x000702DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262101, XrefRangeEnd = 262107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveJoystick(CustomInputSource.Joystick joystick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_RemoveJoystick_Public_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00072120 File Offset: 0x00070320
		[CallerCount(0)]
		public unsafe IList<CustomInputSource.Joystick> GetJoysticks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_GetJoysticks_Public_IList_1_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomInputSource.Joystick>>(intPtr3) : null;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00072160 File Offset: 0x00070360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262107, XrefRangeEnd = 262108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnJoystickConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.NativeMethodInfoPtr_OnJoystickConnected_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0007219C File Offset: 0x0007039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262108, XrefRangeEnd = 262109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnJoystickDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.NativeMethodInfoPtr_OnJoystickDisconnected_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000721D8 File Offset: 0x000703D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262126, RefRangeEnd = 262128, XrefRangeStart = 262109, XrefRangeEnd = 262126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<CustomInputSource.Joystick> VNnJpEzwJVPVMkjzptsRqXYRGvI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.NativeMethodInfoPtr_VNnJpEzwJVPVMkjzptsRqXYRGvI_Internal_Il2CppReferenceArray_1_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomInputSource.Joystick>>(intPtr3) : null;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00072218 File Offset: 0x00070418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262128, XrefRangeEnd = 262132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00072254 File Offset: 0x00070454
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 262133, RefRangeEnd = 262137, XrefRangeStart = 262132, XrefRangeEnd = 262133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00072290 File Offset: 0x00070490
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x000722DC File Offset: 0x000704DC
		public unsafe virtual bool isReady
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.NativeMethodInfoPtr_get_isReady_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00072324 File Offset: 0x00070524
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00008220 File Offset: 0x00006420
		public CustomInputSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00072360 File Offset: 0x00070560
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x00008229 File Offset: 0x00006429
		public unsafe InputSource kjBsrXwNkKBemaKyhvRlDUviZoQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_kjBsrXwNkKBemaKyhvRlDUviZoQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_kjBsrXwNkKBemaKyhvRlDUviZoQ)) = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00072388 File Offset: 0x00070588
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x00008244 File Offset: 0x00006444
		public unsafe List<CustomInputSource.Joystick> xbbcnTFunfOiWypxpNAzMIkgDXj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_xbbcnTFunfOiWypxpNAzMIkgDXj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CustomInputSource.Joystick>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_xbbcnTFunfOiWypxpNAzMIkgDXj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x000723B8 File Offset: 0x000705B8
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x00008263 File Offset: 0x00006463
		public unsafe ReadOnlyCollection<CustomInputSource.Joystick> IwUqVNlsQvUOJZsGUmkbMZGtcjM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_IwUqVNlsQvUOJZsGUmkbMZGtcjM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<CustomInputSource.Joystick>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_IwUqVNlsQvUOJZsGUmkbMZGtcjM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000723E8 File Offset: 0x000705E8
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x00008282 File Offset: 0x00006482
		public unsafe bool QiffcAFtJEuLiqyzTvqImWyGeoE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_QiffcAFtJEuLiqyzTvqImWyGeoE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_QiffcAFtJEuLiqyzTvqImWyGeoE)) = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00072410 File Offset: 0x00070610
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x0000829D File Offset: 0x0000649D
		public unsafe Action bTTdrUgrDHYUeJnQITtlkdJOQXSa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_bTTdrUgrDHYUeJnQITtlkdJOQXSa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_bTTdrUgrDHYUeJnQITtlkdJOQXSa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00072440 File Offset: 0x00070640
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x000082BC File Offset: 0x000064BC
		public unsafe Action SNSIvkupRMZWWmWZZRifMpkXUDw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_SNSIvkupRMZWWmWZZRifMpkXUDw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_SNSIvkupRMZWWmWZZRifMpkXUDw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00072470 File Offset: 0x00070670
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x000082DB File Offset: 0x000064DB
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeFieldInfoPtr_kjBsrXwNkKBemaKyhvRlDUviZoQ;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_xbbcnTFunfOiWypxpNAzMIkgDXj;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeFieldInfoPtr_IwUqVNlsQvUOJZsGUmkbMZGtcjM;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeFieldInfoPtr_QiffcAFtJEuLiqyzTvqImWyGeoE;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeFieldInfoPtr_bTTdrUgrDHYUeJnQITtlkdJOQXSa;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeFieldInfoPtr_SNSIvkupRMZWWmWZZRifMpkXUDw;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_get_useApproximateMatching_Public_get_Boolean_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_set_useApproximateMatching_Protected_set_Void_Boolean_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_add__JoystickConnectedEvent_Private_add_Void_Action_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_remove__JoystickConnectedEvent_Private_rem_Void_Action_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_add__JoystickDisconnectedEvent_Private_add_Void_Action_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_remove__JoystickDisconnectedEvent_Private_rem_Void_Action_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_add_JoystickConnectedEvent_Internal_add_Void_Action_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_remove_JoystickConnectedEvent_Internal_rem_Void_Action_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_add_JoystickDisconnectedEvent_Internal_add_Void_Action_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_remove_JoystickDisconnectedEvent_Internal_rem_Void_Action_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Internal_get_InputSource_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_AddJoystick_Public_Void_Joystick_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_RemoveJoystick_Public_Void_Joystick_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_GetJoysticks_Public_IList_1_Joystick_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_OnJoystickConnected_Protected_Virtual_New_Void_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_OnJoystickDisconnected_Protected_Virtual_New_Void_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_VNnJpEzwJVPVMkjzptsRqXYRGvI_Internal_Il2CppReferenceArray_1_Joystick_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_get_isReady_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x020002B1 RID: 689
		public class Controller : Object
		{
			// Token: 0x06003CF5 RID: 15605 RVA: 0x00123A58 File Offset: 0x00121C58
			// Note: this type is marked as 'beforefieldinit'.
			static Controller()
			{
				Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "Controller");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr);
				CustomInputSource.Controller.NativeFieldInfoPtr__isConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, "_isConnected");
				CustomInputSource.Controller.NativeFieldInfoPtr__deviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, "_deviceName");
				CustomInputSource.Controller.NativeFieldInfoPtr__customName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, "_customName");
				CustomInputSource.Controller.NativeMethodInfoPtr_get_customName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, 100666392);
				CustomInputSource.Controller.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, 100666393);
				CustomInputSource.Controller.NativeMethodInfoPtr_set_isConnected_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, 100666394);
				CustomInputSource.Controller.NativeMethodInfoPtr_get_deviceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, 100666395);
				CustomInputSource.Controller.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, 100666396);
				CustomInputSource.Controller.NativeMethodInfoPtr_Disconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, 100666397);
				CustomInputSource.Controller.NativeMethodInfoPtr_Connect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, 100666398);
				CustomInputSource.Controller.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr, 100666399);
			}

			// Token: 0x170012A5 RID: 4773
			// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x00123B60 File Offset: 0x00121D60
			public unsafe string customName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Controller.NativeMethodInfoPtr_get_customName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170012A6 RID: 4774
			// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x00123B98 File Offset: 0x00121D98
			// (set) Token: 0x06003CF8 RID: 15608 RVA: 0x00123BD4 File Offset: 0x00121DD4
			public unsafe bool isConnected
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Controller.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Controller.NativeMethodInfoPtr_set_isConnected_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170012A7 RID: 4775
			// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x00123C14 File Offset: 0x00121E14
			public unsafe string deviceName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Controller.NativeMethodInfoPtr_get_deviceName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003CFA RID: 15610 RVA: 0x00123C4C File Offset: 0x00121E4C
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Controller(string deviceName)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputSource.Controller>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(deviceName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Controller.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003CFB RID: 15611 RVA: 0x00123C98 File Offset: 0x00121E98
			[CallerCount(0)]
			public unsafe void Disconnect()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Controller.NativeMethodInfoPtr_Disconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CFC RID: 15612 RVA: 0x00123CCC File Offset: 0x00121ECC
			[CallerCount(0)]
			public unsafe void Connect()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Controller.NativeMethodInfoPtr_Connect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CFD RID: 15613 RVA: 0x00123D00 File Offset: 0x00121F00
			[CallerCount(0)]
			public unsafe virtual void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.Controller.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CFE RID: 15614 RVA: 0x000159F4 File Offset: 0x00013BF4
			public Controller(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012A2 RID: 4770
			// (get) Token: 0x06003CFF RID: 15615 RVA: 0x00123D3C File Offset: 0x00121F3C
			// (set) Token: 0x06003D00 RID: 15616 RVA: 0x000159FD File Offset: 0x00013BFD
			public unsafe bool _isConnected
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Controller.NativeFieldInfoPtr__isConnected);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Controller.NativeFieldInfoPtr__isConnected)) = value;
				}
			}

			// Token: 0x170012A3 RID: 4771
			// (get) Token: 0x06003D01 RID: 15617 RVA: 0x00123D64 File Offset: 0x00121F64
			// (set) Token: 0x06003D02 RID: 15618 RVA: 0x00015A18 File Offset: 0x00013C18
			public unsafe string _deviceName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Controller.NativeFieldInfoPtr__deviceName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Controller.NativeFieldInfoPtr__deviceName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170012A4 RID: 4772
			// (get) Token: 0x06003D03 RID: 15619 RVA: 0x00123D8C File Offset: 0x00121F8C
			// (set) Token: 0x06003D04 RID: 15620 RVA: 0x00015A37 File Offset: 0x00013C37
			public unsafe string _customName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Controller.NativeFieldInfoPtr__customName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Controller.NativeFieldInfoPtr__customName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040032C8 RID: 13000
			private static readonly IntPtr NativeFieldInfoPtr__isConnected;

			// Token: 0x040032C9 RID: 13001
			private static readonly IntPtr NativeFieldInfoPtr__deviceName;

			// Token: 0x040032CA RID: 13002
			private static readonly IntPtr NativeFieldInfoPtr__customName;

			// Token: 0x040032CB RID: 13003
			private static readonly IntPtr NativeMethodInfoPtr_get_customName_Public_get_String_0;

			// Token: 0x040032CC RID: 13004
			private static readonly IntPtr NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0;

			// Token: 0x040032CD RID: 13005
			private static readonly IntPtr NativeMethodInfoPtr_set_isConnected_Public_set_Void_Boolean_0;

			// Token: 0x040032CE RID: 13006
			private static readonly IntPtr NativeMethodInfoPtr_get_deviceName_Public_get_String_0;

			// Token: 0x040032CF RID: 13007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

			// Token: 0x040032D0 RID: 13008
			private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_0;

			// Token: 0x040032D1 RID: 13009
			private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_0;

			// Token: 0x040032D2 RID: 13010
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;
		}

		// Token: 0x020002B2 RID: 690
		public class Joystick : CustomInputSource.Controller
		{
			// Token: 0x06003D05 RID: 15621 RVA: 0x00123DB4 File Offset: 0x00121FB4
			// Note: this type is marked as 'beforefieldinit'.
			static Joystick()
			{
				Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "Joystick");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr);
				CustomInputSource.Joystick.NativeFieldInfoPtr_gvXnpGAuHOwyyLxuGQastVwuaHQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, "gvXnpGAuHOwyyLxuGQastVwuaHQ");
				CustomInputSource.Joystick.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, "pqTtSCngKtHengXqufyfMylPsXx");
				CustomInputSource.Joystick.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, "yPmaEVkiAXCCzJsPBnVnFFukdZK");
				CustomInputSource.Joystick.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, "GuxtgegCZiWJDenlSEVuDZKGNKPu");
				CustomInputSource.Joystick.NativeFieldInfoPtr_qePVktyxBhmaaxMeMhRxeEftTXZn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, "qePVktyxBhmaaxMeMhRxeEftTXZn");
				CustomInputSource.Joystick.NativeFieldInfoPtr_pkbzarsvTGkNCTNGNnfjDNndVNz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, "pkbzarsvTGkNCTNGNnfjDNndVNz");
				CustomInputSource.Joystick.NativeFieldInfoPtr_GpmFnBAxUAdXwLkqaXOSEemYXrFI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, "GpmFnBAxUAdXwLkqaXOSEemYXrFI");
				CustomInputSource.Joystick.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, "sZKOvZaohDAzdPVObwABOvwFgQN");
				CustomInputSource.Joystick.NativeMethodInfoPtr_get_systemId_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666400);
				CustomInputSource.Joystick.NativeMethodInfoPtr_set_systemId_Protected_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666401);
				CustomInputSource.Joystick.NativeMethodInfoPtr_get_unityId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666402);
				CustomInputSource.Joystick.NativeMethodInfoPtr_set_unityId_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666403);
				CustomInputSource.Joystick.NativeMethodInfoPtr_get_Axes_Public_get_IList_1_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666404);
				CustomInputSource.Joystick.NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666405);
				CustomInputSource.Joystick.NativeMethodInfoPtr_get_supportsVibration_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666406);
				CustomInputSource.Joystick.NativeMethodInfoPtr_set_supportsVibration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666407);
				CustomInputSource.Joystick.NativeMethodInfoPtr_get_extension_Public_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666408);
				CustomInputSource.Joystick.NativeMethodInfoPtr_set_extension_Public_set_Void_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666409);
				CustomInputSource.Joystick.NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666410);
				CustomInputSource.Joystick.NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666411);
				CustomInputSource.Joystick.NativeMethodInfoPtr__ctor_Public_Void_String_Nullable_1_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666412);
				CustomInputSource.Joystick.NativeMethodInfoPtr_GetAxisValue_Public_Virtual_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666413);
				CustomInputSource.Joystick.NativeMethodInfoPtr_GetButtonValue_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr, 100666414);
			}

			// Token: 0x170012B0 RID: 4784
			// (get) Token: 0x06003D06 RID: 15622 RVA: 0x00123FAC File Offset: 0x001221AC
			// (set) Token: 0x06003D07 RID: 15623 RVA: 0x00123FE4 File Offset: 0x001221E4
			public unsafe Nullable<long> systemId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_get_systemId_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_set_systemId_Protected_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170012B1 RID: 4785
			// (get) Token: 0x06003D08 RID: 15624 RVA: 0x0012402C File Offset: 0x0012222C
			// (set) Token: 0x06003D09 RID: 15625 RVA: 0x00124068 File Offset: 0x00122268
			public unsafe int unityId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_get_unityId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_set_unityId_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170012B2 RID: 4786
			// (get) Token: 0x06003D0A RID: 15626 RVA: 0x001240A8 File Offset: 0x001222A8
			public unsafe IList<CustomInputSource.Axis> Axes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_get_Axes_Public_get_IList_1_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomInputSource.Axis>>(intPtr3) : null;
				}
			}

			// Token: 0x170012B3 RID: 4787
			// (get) Token: 0x06003D0B RID: 15627 RVA: 0x001240E8 File Offset: 0x001222E8
			public unsafe IList<CustomInputSource.Button> Buttons
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomInputSource.Button>>(intPtr3) : null;
				}
			}

			// Token: 0x170012B4 RID: 4788
			// (get) Token: 0x06003D0C RID: 15628 RVA: 0x00124128 File Offset: 0x00122328
			// (set) Token: 0x06003D0D RID: 15629 RVA: 0x00124164 File Offset: 0x00122364
			public unsafe virtual bool supportsVibration
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_get_supportsVibration_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_set_supportsVibration_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170012B5 RID: 4789
			// (get) Token: 0x06003D0E RID: 15630 RVA: 0x001241A4 File Offset: 0x001223A4
			// (set) Token: 0x06003D0F RID: 15631 RVA: 0x001241E4 File Offset: 0x001223E4
			public unsafe Il2CppRewired.Controller.Extension extension
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_get_extension_Public_get_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppRewired.Controller.Extension>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_set_extension_Public_set_Void_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170012B6 RID: 4790
			// (get) Token: 0x06003D10 RID: 15632 RVA: 0x00124228 File Offset: 0x00122428
			public unsafe int buttonCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170012B7 RID: 4791
			// (get) Token: 0x06003D11 RID: 15633 RVA: 0x00124264 File Offset: 0x00122464
			public unsafe int axisCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D12 RID: 15634 RVA: 0x001242A0 File Offset: 0x001224A0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 262041, RefRangeEnd = 262043, XrefRangeStart = 262017, XrefRangeEnd = 262041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Joystick(string deviceName, Nullable<long> systemId, int unityId, int axisCount, int buttonCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputSource.Joystick>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(deviceName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(systemId));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Joystick.NativeMethodInfoPtr__ctor_Public_Void_String_Nullable_1_Int64_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D13 RID: 15635 RVA: 0x0012432C File Offset: 0x0012252C
			[CallerCount(0)]
			public unsafe virtual float GetAxisValue(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.Joystick.NativeMethodInfoPtr_GetAxisValue_Public_Virtual_New_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D14 RID: 15636 RVA: 0x00124380 File Offset: 0x00122580
			[CallerCount(0)]
			public unsafe virtual bool GetButtonValue(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomInputSource.Joystick.NativeMethodInfoPtr_GetButtonValue_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D15 RID: 15637 RVA: 0x00015A56 File Offset: 0x00013C56
			public Joystick(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012A8 RID: 4776
			// (get) Token: 0x06003D16 RID: 15638 RVA: 0x001243D4 File Offset: 0x001225D4
			// (set) Token: 0x06003D17 RID: 15639 RVA: 0x00015A5F File Offset: 0x00013C5F
			public Nullable<long> gvXnpGAuHOwyyLxuGQastVwuaHQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_gvXnpGAuHOwyyLxuGQastVwuaHQ);
					return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_gvXnpGAuHOwyyLxuGQastVwuaHQ), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170012A9 RID: 4777
			// (get) Token: 0x06003D18 RID: 15640 RVA: 0x00124404 File Offset: 0x00122604
			// (set) Token: 0x06003D19 RID: 15641 RVA: 0x00015A8D File Offset: 0x00013C8D
			public unsafe int pqTtSCngKtHengXqufyfMylPsXx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx)) = value;
				}
			}

			// Token: 0x170012AA RID: 4778
			// (get) Token: 0x06003D1A RID: 15642 RVA: 0x0012442C File Offset: 0x0012262C
			// (set) Token: 0x06003D1B RID: 15643 RVA: 0x00015AA8 File Offset: 0x00013CA8
			public unsafe Il2CppReferenceArray<CustomInputSource.Axis> yPmaEVkiAXCCzJsPBnVnFFukdZK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomInputSource.Axis>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012AB RID: 4779
			// (get) Token: 0x06003D1C RID: 15644 RVA: 0x0012445C File Offset: 0x0012265C
			// (set) Token: 0x06003D1D RID: 15645 RVA: 0x00015AC7 File Offset: 0x00013CC7
			public unsafe Il2CppReferenceArray<CustomInputSource.Button> GuxtgegCZiWJDenlSEVuDZKGNKPu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomInputSource.Button>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012AC RID: 4780
			// (get) Token: 0x06003D1E RID: 15646 RVA: 0x0012448C File Offset: 0x0012268C
			// (set) Token: 0x06003D1F RID: 15647 RVA: 0x00015AE6 File Offset: 0x00013CE6
			public unsafe ReadOnlyCollection<CustomInputSource.Axis> qePVktyxBhmaaxMeMhRxeEftTXZn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_qePVktyxBhmaaxMeMhRxeEftTXZn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<CustomInputSource.Axis>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_qePVktyxBhmaaxMeMhRxeEftTXZn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012AD RID: 4781
			// (get) Token: 0x06003D20 RID: 15648 RVA: 0x001244BC File Offset: 0x001226BC
			// (set) Token: 0x06003D21 RID: 15649 RVA: 0x00015B05 File Offset: 0x00013D05
			public unsafe ReadOnlyCollection<CustomInputSource.Button> pkbzarsvTGkNCTNGNnfjDNndVNz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_pkbzarsvTGkNCTNGNnfjDNndVNz);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<CustomInputSource.Button>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_pkbzarsvTGkNCTNGNnfjDNndVNz), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012AE RID: 4782
			// (get) Token: 0x06003D22 RID: 15650 RVA: 0x001244EC File Offset: 0x001226EC
			// (set) Token: 0x06003D23 RID: 15651 RVA: 0x00015B24 File Offset: 0x00013D24
			public unsafe bool GpmFnBAxUAdXwLkqaXOSEemYXrFI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_GpmFnBAxUAdXwLkqaXOSEemYXrFI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_GpmFnBAxUAdXwLkqaXOSEemYXrFI)) = value;
				}
			}

			// Token: 0x170012AF RID: 4783
			// (get) Token: 0x06003D24 RID: 15652 RVA: 0x00124514 File Offset: 0x00122714
			// (set) Token: 0x06003D25 RID: 15653 RVA: 0x00015B3F File Offset: 0x00013D3F
			public unsafe Il2CppRewired.Controller.Extension sZKOvZaohDAzdPVObwABOvwFgQN
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppRewired.Controller.Extension>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Joystick.NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032D3 RID: 13011
			private static readonly IntPtr NativeFieldInfoPtr_gvXnpGAuHOwyyLxuGQastVwuaHQ;

			// Token: 0x040032D4 RID: 13012
			private static readonly IntPtr NativeFieldInfoPtr_pqTtSCngKtHengXqufyfMylPsXx;

			// Token: 0x040032D5 RID: 13013
			private static readonly IntPtr NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK;

			// Token: 0x040032D6 RID: 13014
			private static readonly IntPtr NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu;

			// Token: 0x040032D7 RID: 13015
			private static readonly IntPtr NativeFieldInfoPtr_qePVktyxBhmaaxMeMhRxeEftTXZn;

			// Token: 0x040032D8 RID: 13016
			private static readonly IntPtr NativeFieldInfoPtr_pkbzarsvTGkNCTNGNnfjDNndVNz;

			// Token: 0x040032D9 RID: 13017
			private static readonly IntPtr NativeFieldInfoPtr_GpmFnBAxUAdXwLkqaXOSEemYXrFI;

			// Token: 0x040032DA RID: 13018
			private static readonly IntPtr NativeFieldInfoPtr_sZKOvZaohDAzdPVObwABOvwFgQN;

			// Token: 0x040032DB RID: 13019
			private static readonly IntPtr NativeMethodInfoPtr_get_systemId_Public_get_Nullable_1_Int64_0;

			// Token: 0x040032DC RID: 13020
			private static readonly IntPtr NativeMethodInfoPtr_set_systemId_Protected_set_Void_Nullable_1_Int64_0;

			// Token: 0x040032DD RID: 13021
			private static readonly IntPtr NativeMethodInfoPtr_get_unityId_Public_get_Int32_0;

			// Token: 0x040032DE RID: 13022
			private static readonly IntPtr NativeMethodInfoPtr_set_unityId_Protected_set_Void_Int32_0;

			// Token: 0x040032DF RID: 13023
			private static readonly IntPtr NativeMethodInfoPtr_get_Axes_Public_get_IList_1_Axis_0;

			// Token: 0x040032E0 RID: 13024
			private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_get_IList_1_Button_0;

			// Token: 0x040032E1 RID: 13025
			private static readonly IntPtr NativeMethodInfoPtr_get_supportsVibration_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040032E2 RID: 13026
			private static readonly IntPtr NativeMethodInfoPtr_set_supportsVibration_Public_set_Void_Boolean_0;

			// Token: 0x040032E3 RID: 13027
			private static readonly IntPtr NativeMethodInfoPtr_get_extension_Public_get_Extension_0;

			// Token: 0x040032E4 RID: 13028
			private static readonly IntPtr NativeMethodInfoPtr_set_extension_Public_set_Void_Extension_0;

			// Token: 0x040032E5 RID: 13029
			private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0;

			// Token: 0x040032E6 RID: 13030
			private static readonly IntPtr NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0;

			// Token: 0x040032E7 RID: 13031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Nullable_1_Int64_Int32_Int32_Int32_0;

			// Token: 0x040032E8 RID: 13032
			private static readonly IntPtr NativeMethodInfoPtr_GetAxisValue_Public_Virtual_New_Single_Int32_0;

			// Token: 0x040032E9 RID: 13033
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonValue_Public_Virtual_New_Boolean_Int32_0;
		}

		// Token: 0x020002B3 RID: 691
		public class Element : Object
		{
			// Token: 0x06003D26 RID: 15654 RVA: 0x00015B5E File Offset: 0x00013D5E
			// Note: this type is marked as 'beforefieldinit'.
			static Element()
			{
				Il2CppClassPointerStore<CustomInputSource.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "Element");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputSource.Element>.NativeClassPtr);
				CustomInputSource.Element.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Element>.NativeClassPtr, 100666415);
			}

			// Token: 0x06003D27 RID: 15655 RVA: 0x00124544 File Offset: 0x00122744
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Element()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputSource.Element>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Element.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D28 RID: 15656 RVA: 0x00015B92 File Offset: 0x00013D92
			public Element(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040032EA RID: 13034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x020002B4 RID: 692
		public sealed class Axis : CustomInputSource.Element
		{
			// Token: 0x06003D29 RID: 15657 RVA: 0x00124580 File Offset: 0x00122780
			// Note: this type is marked as 'beforefieldinit'.
			static Axis()
			{
				Il2CppClassPointerStore<CustomInputSource.Axis>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "Axis");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputSource.Axis>.NativeClassPtr);
				CustomInputSource.Axis.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Axis>.NativeClassPtr, "value");
				CustomInputSource.Axis.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Axis>.NativeClassPtr, 100666416);
			}

			// Token: 0x06003D2A RID: 15658 RVA: 0x001245D4 File Offset: 0x001227D4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputSource.Axis>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Axis.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D2B RID: 15659 RVA: 0x00015B9B File Offset: 0x00013D9B
			public Axis(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012B8 RID: 4792
			// (get) Token: 0x06003D2C RID: 15660 RVA: 0x00124610 File Offset: 0x00122810
			// (set) Token: 0x06003D2D RID: 15661 RVA: 0x00015BA4 File Offset: 0x00013DA4
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Axis.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Axis.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x040032EB RID: 13035
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040032EC RID: 13036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002B5 RID: 693
		public sealed class Button : CustomInputSource.Element
		{
			// Token: 0x06003D2E RID: 15662 RVA: 0x00124638 File Offset: 0x00122838
			// Note: this type is marked as 'beforefieldinit'.
			static Button()
			{
				Il2CppClassPointerStore<CustomInputSource.Button>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomInputSource>.NativeClassPtr, "Button");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputSource.Button>.NativeClassPtr);
				CustomInputSource.Button.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputSource.Button>.NativeClassPtr, "value");
				CustomInputSource.Button.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputSource.Button>.NativeClassPtr, 100666417);
			}

			// Token: 0x06003D2F RID: 15663 RVA: 0x0012468C File Offset: 0x0012288C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Button()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputSource.Button>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomInputSource.Button.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D30 RID: 15664 RVA: 0x00015BBF File Offset: 0x00013DBF
			public Button(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012B9 RID: 4793
			// (get) Token: 0x06003D31 RID: 15665 RVA: 0x001246C8 File Offset: 0x001228C8
			// (set) Token: 0x06003D32 RID: 15666 RVA: 0x00015BC8 File Offset: 0x00013DC8
			public unsafe bool value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Button.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomInputSource.Button.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x040032ED RID: 13037
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040032EE RID: 13038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
