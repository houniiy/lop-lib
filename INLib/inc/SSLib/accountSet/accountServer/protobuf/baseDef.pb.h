// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: baseDef.proto

#ifndef PROTOBUF_baseDef_2eproto__INCLUDED
#define PROTOBUF_baseDef_2eproto__INCLUDED

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 2005000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 2005000 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/repeated_field.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/generated_enum_reflection.h>
// @@protoc_insertion_point(includes)

namespace PTBuf {

// Internal implementation detail -- do not call these.
void  protobuf_AddDesc_baseDef_2eproto();
void protobuf_AssignDesc_baseDef_2eproto();
void protobuf_ShutdownFile_baseDef_2eproto();


enum PBECurrencyType {
  PBE_CURRENCY_TYPE_INVALID = 0,
  PBE_CURRENCY_TYPE_COIN = 1,
  PBE_CURRENCY_TYPE_DIAMOND = 2
};
bool PBECurrencyType_IsValid(int value);
const PBECurrencyType PBECurrencyType_MIN = PBE_CURRENCY_TYPE_INVALID;
const PBECurrencyType PBECurrencyType_MAX = PBE_CURRENCY_TYPE_DIAMOND;
const int PBECurrencyType_ARRAYSIZE = PBECurrencyType_MAX + 1;

const ::google::protobuf::EnumDescriptor* PBECurrencyType_descriptor();
inline const ::std::string& PBECurrencyType_Name(PBECurrencyType value) {
  return ::google::protobuf::internal::NameOfEnum(
    PBECurrencyType_descriptor(), value);
}
inline bool PBECurrencyType_Parse(
    const ::std::string& name, PBECurrencyType* value) {
  return ::google::protobuf::internal::ParseNamedEnum<PBECurrencyType>(
    PBECurrencyType_descriptor(), name, value);
}
// ===================================================================


// ===================================================================


// ===================================================================


// @@protoc_insertion_point(namespace_scope)

}  // namespace PTBuf

#ifndef SWIG
namespace google {
namespace protobuf {

template <>
inline const EnumDescriptor* GetEnumDescriptor< ::PTBuf::PBECurrencyType>() {
  return ::PTBuf::PBECurrencyType_descriptor();
}

}  // namespace google
}  // namespace protobuf
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_baseDef_2eproto__INCLUDED
